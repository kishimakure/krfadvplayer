/**
 * krfadvplayer Stats Worker
 *
 * Endpoints:
 *   POST /play    { advIds: number[] }       — 增加播放计数（含当日日期桶），返回 { ok, total }
 *   GET  /stats                              — 全量统计（不含 daily 原始数据）
 *   GET  /stats?days=N                       — 仅统计最近 N 天的数据
 *   POST /reset   Header: X-Reset-Token: <secret>
 *                                            — 备份当前数据并重置，返回 { ok, backupKey, previous }
 *
 * R2 binding:    STATS_BUCKET
 * Worker secret: RESET_TOKEN  （通过 wrangler secret put RESET_TOKEN 设置）
 *
 * play_stats.json 结构：
 * {
 *   "total": 158,
 *   "byAdv": { "10001": 42 },
 *   "daily": {
 *     "2026-07-01": { "total": 5, "byAdv": { "10001": 3 } }
 *   }
 * }
 */

const STATS_KEY = 'play_stats.json';
const SESSION_PREFIX = 'play_sessions/';
/* sessions non-finalized longer than this are considered interrupted */
const STUCK_TIMEOUT_MS = 2 * 60 * 60 * 1000;

function nowIso() {
    return new Date().toISOString();
}

function dayKeyFromIso(isoString) {
    if (!isoString || typeof isoString !== 'string') return nowIso().slice(0, 10);
    return isoString.slice(0, 10);
}

function sessionKey(sessionId, startedAt) {
    const dayKey = dayKeyFromIso(startedAt);
    return `${SESSION_PREFIX}${dayKey}/${sessionId}.json`;
}

function normalizeAdvIds(input) {
    if (!Array.isArray(input)) return [];
    return input.map(Number).filter(n => Number.isFinite(n) && n > 0);
}

function formatDuration(ms) {
    if (!Number.isFinite(ms) || ms < 0) return null;
    const totalSeconds = Math.floor(ms / 1000);
    const hours = Math.floor(totalSeconds / 3600);
    const minutes = Math.floor((totalSeconds % 3600) / 60);
    const seconds = totalSeconds % 60;
    const pad = (n) => String(n).padStart(2, '0');
    return hours > 0 ? `${hours}:${pad(minutes)}:${pad(seconds)}` : `${minutes}:${pad(seconds)}`;
}

function displayStatusCode(record, isLegacy = false) {
    if (isLegacy) return 'legacy';
    const status = record && record.status ? String(record.status) : 'pending';
    return status;
}

function displayStatusLabel(code) {
    switch (code) {
        case 'pending': return 'Pending';
        case 'loading_webgl': return 'Loading WebGL';
        case 'webgl_ready': return 'WebGL ready';
        case 'blocked_before_webgl': return 'Blocked before WebGL';
        case 'load_failed_before_webgl': return 'Loading failed before WebGL';
        case 'webgl_error': return 'WebGL/runtime error';
        case 'quit_success': return 'Exited cleanly';
        case 'quit_with_errors': return 'Exited (with JS errors)';
        case 'quit_failed': return 'Exit failed';
        case 'closed_without_exit': return 'Closed without exit';
        case 'error_before_pagehide': return 'Closed after JS error';
        case 'aborted_before_webgl': return 'Closed before WebGL';
        case 'interrupted': return 'Interrupted (no exit signal)';
        case 'legacy': return 'Legacy record';
        default: return code;
    }
}

async function readJsonObject(bucket, key, fallback) {
    const obj = await bucket.get(key);
    if (!obj) return fallback;
    try { return JSON.parse(await obj.text()); }
    catch (_) { return fallback; }
}

async function writeJsonObject(bucket, key, data) {
    await bucket.put(key, JSON.stringify(data), {
        httpMetadata: { contentType: 'application/json' },
    });
}

async function loadStats(env) {
    return readJsonObject(env.STATS_BUCKET, STATS_KEY, { total: 0, byAdv: {}, daily: {} });
}

function recomputeFromSessions(stats) {
    /* Rebuild total / byAdv / daily totals from the sessions[] arrays. */
    let total = 0;
    const byAdv = {};
    const daily = stats.daily || {};
    for (const dayStats of Object.values(daily)) {
        let dayTotal = 0;
        const dayByAdv = {};
        for (const session of (dayStats.sessions || [])) {
            const ids = normalizeAdvIds(session.ids || session.advIds || []);
            dayTotal += ids.length;
            ids.forEach(id => {
                const k = String(id);
                dayByAdv[k] = (dayByAdv[k] || 0) + 1;
                byAdv[k]    = (byAdv[k]    || 0) + 1;
            });
        }
        total += dayTotal;
        dayStats.total = dayTotal;
        dayStats.byAdv = dayByAdv;
    }
    stats.total = total;
    stats.byAdv = byAdv;
}

async function upsertSessionRecord(env, record, merge = {}) {
    const key = sessionKey(record.sessionId, record.startedAt);
    const previous = await readJsonObject(env.STATS_BUCKET, key, null);
    const next = {
        ...(previous || {}),
        ...record,
        ...merge,
        sessionId: record.sessionId,
        startedAt: record.startedAt,
        updatedAt: nowIso(),
    };
    // Once finalized, terminal-state fields are immutable (guards against late-arriving start/update)
    if (previous && previous.finalized) {
        next.status      = previous.status;
        next.stage       = previous.stage;
        next.finalized   = true;
        next.finalizedAt = previous.finalizedAt;
        next.endedAt     = previous.endedAt;
        next.durationMs  = previous.durationMs;
    }
    await writeJsonObject(env.STATS_BUCKET, key, next);
    return next;
}

async function listAllObjects(bucket, prefix) {
    const all = [];
    let cursor;
    do {
        const res = await bucket.list({ prefix, cursor, limit: 1000 });
        all.push(...res.objects);
        cursor = res.truncated ? res.cursor : null;
    } while (cursor);
    return all;
}

function legacySessionRecords(stats, cutoffStr) {
    const records = [];
    const daily = stats.daily || {};
    for (const [day, dayStats] of Object.entries(daily)) {
        if (cutoffStr && day < cutoffStr) continue;
        (dayStats.sessions || []).forEach((session, index) => {
            /* new-format sessions have sessionId and a matching R2 file — skip here */
            if (session.sessionId) return;
            records.push({
                sessionId: `legacy-${day}-${index}`,
                startedAt: session.t,
                updatedAt: session.t,
                finalizedAt: session.t,
                advIds: Array.isArray(session.ids) ? session.ids : [],
                status: 'legacy',
                durationMs: null,
                fromLegacy: true,
            });
        });
    }
    return records;
}

const CORS_HEADERS = {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'POST, GET, DELETE, OPTIONS',
    'Access-Control-Allow-Headers': 'Content-Type, X-Reset-Token',
};

export default {
    async fetch(request, env) {
        /* Preflight */
        if (request.method === 'OPTIONS') {
            return new Response(null, { status: 204, headers: CORS_HEADERS });
        }

        const url = new URL(request.url);

        /* ── POST /play ── */
        if (request.method === 'POST' && url.pathname === '/play') {
            let advIds = [];
            try {
                const body = await request.json();
                advIds = normalizeAdvIds(body.advIds);
            } catch (_) { /* JSON 解析失败则 advIds 为空，仍计总数 */ }

            /* 读取现有统计 */
            let stats = await loadStats(env);
            if (!stats.daily) stats.daily = {};
            if (!stats.byAdv)  stats.byAdv  = {};

            /* 全量计数：按本次播放的剧情数累加 */
            stats.total = (stats.total || 0) + advIds.length;
            advIds.forEach(id => {
                const k = String(id);
                stats.byAdv[k] = (stats.byAdv[k] || 0) + 1;
            });

            /* 更新当天日期桶（UTC 日期，格式 "2026-07-01"） */
            const now = new Date();
            const today = nowIso().slice(0, 10);
            if (!stats.daily[today]) stats.daily[today] = { total: 0, byAdv: {}, sessions: [] };
            if (!stats.daily[today].sessions) stats.daily[today].sessions = [];
            stats.daily[today].total = (stats.daily[today].total || 0) + advIds.length;
            advIds.forEach(id => {
                const k = String(id);
                if (!stats.daily[today].byAdv) stats.daily[today].byAdv = {};
                stats.daily[today].byAdv[k] = (stats.daily[today].byAdv[k] || 0) + 1;
            });

            /* 记录精确时间戳的会话日志 */
            stats.daily[today].sessions.push({ t: now.toISOString(), ids: advIds });

            /* 写回 R2 */
            await env.STATS_BUCKET.put(STATS_KEY, JSON.stringify(stats), {
                httpMetadata: { contentType: 'application/json' },
            });

            return new Response(JSON.stringify({ ok: true, total: stats.total }), {
                headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
            });
        }

        /* ── POST /session ── */
        if (request.method === 'POST' && url.pathname === '/session') {
            let body;
            try { body = await request.json(); }
            catch (_) { body = {}; }

            const action = String(body.action || 'update');
            const sessionId = String(body.sessionId || '').trim();
            if (!sessionId) {
                return new Response(JSON.stringify({ ok: false, error: 'Missing sessionId' }), {
                    status: 400,
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }

            const startedAt = String(body.startedAt || nowIso());
            const advIds = normalizeAdvIds(body.advIds);
            const key = sessionKey(sessionId, startedAt);
            const now = nowIso();
            const existing = await readJsonObject(env.STATS_BUCKET, key, null);

            if (action === 'start') {
                /* stats are updated only on finalize; start only creates the session file */
                const record = await upsertSessionRecord(env, {
                    sessionId,
                    startedAt,
                    advIds,
                    status: 'pending',
                    stage: 'loading',
                    finalized: false,
                    durationMs: null,
                    errorMessage: '',
                    createdAt: now,
                });
                return new Response(JSON.stringify({ ok: true, sessionId, status: record.status }), {
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }

            const base = existing || {
                sessionId,
                startedAt,
                advIds,
                status: 'pending',
                stage: 'loading',
                finalized: false,
                createdAt: now,
            };

            const merged = {
                ...base,
                ...(action === 'update' ? {
                    ...(body.status ? { status: String(body.status) } : {}),
                    ...(body.stage ? { stage: String(body.stage) } : {}),
                    ...(body.loadedAt ? { loadedAt: String(body.loadedAt) } : {}),
                    ...(body.errorMessage ? { errorMessage: String(body.errorMessage) } : {}),
                    ...(body.errorStage ? { errorStage: String(body.errorStage) } : {}),
                    ...(body.enteredWebGL != null ? { enteredWebGL: !!body.enteredWebGL } : {}),
                } : {}),
            };

            if (action === 'finalize') {
                const status = String(body.status || merged.status || 'pending');
                const endedAt = String(body.endedAt || now);
                const durationMs = Number.isFinite(Number(body.durationMs))
                    ? Number(body.durationMs)
                    : Math.max(0, Date.parse(endedAt) - Date.parse(startedAt));
                merged.status = status;
                merged.finalized = true;
                merged.finalizedAt = endedAt;
                merged.endedAt = endedAt;
                merged.durationMs = durationMs;
                if (body.stage) merged.stage = String(body.stage);
                if (body.errorMessage) merged.errorMessage = String(body.errorMessage);
                if (body.errorStage) merged.errorStage = String(body.errorStage);
                if (!merged.advIds || merged.advIds.length === 0) merged.advIds = advIds;
            }

            const record = await upsertSessionRecord(env, merged);

            /* on finalize: append compact record to play_stats.json and recompute */
            if (action === 'finalize') {
                const stats = await loadStats(env);
                if (!stats.daily) stats.daily = {};
                const day = dayKeyFromIso(startedAt);
                if (!stats.daily[day]) stats.daily[day] = { sessions: [] };
                if (!stats.daily[day].sessions) stats.daily[day].sessions = [];
                /* avoid duplicates on retried finalize */
                if (!stats.daily[day].sessions.some(s => s.sessionId === sessionId)) {
                    stats.daily[day].sessions.push({
                        sessionId,
                        t: startedAt,
                        ids: (record.advIds && record.advIds.length) ? record.advIds : advIds,
                        status: record.status,
                    });
                }
                recomputeFromSessions(stats);
                await writeJsonObject(env.STATS_BUCKET, STATS_KEY, stats);
            }

            return new Response(JSON.stringify({ ok: true, sessionId, status: record.status }), {
                headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
            });
        }

        /* ── GET /stats  /  GET /stats?days=N ── */
        if (request.method === 'GET' && url.pathname === '/stats') {
            const obj = await env.STATS_BUCKET.get(STATS_KEY);
            if (!obj) {
                return new Response(JSON.stringify({ total: 0, byAdv: {} }), {
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }

            let stats;
            try { stats = JSON.parse(await obj.text()); }
            catch (_) { stats = { total: 0, byAdv: {} }; }

            const daysParam = url.searchParams.get('days');
            const days = daysParam ? parseInt(daysParam) : null;

            if (days && Number.isFinite(days) && days > 0) {
                /* 按天数筛选：仅合计最近 N 天的日期桶；排除以 9 开头的 advId */
                const daily = stats.daily || {};
                const cutoff = new Date();
                cutoff.setUTCDate(cutoff.getUTCDate() - days);
                const cutoffStr = cutoff.toISOString().slice(0, 10);

                let filteredTotal = 0;
                const filteredByAdv = {};
                for (const [date, dayStats] of Object.entries(daily)) {
                    if (date >= cutoffStr) {
                        for (const [id, cnt] of Object.entries(dayStats.byAdv || {})) {
                            if (!id.startsWith('9')) {
                                filteredByAdv[id] = (filteredByAdv[id] || 0) + cnt;
                                filteredTotal += cnt;
                            }
                        }
                    }
                }
                return new Response(JSON.stringify({ total: filteredTotal, byAdv: filteredByAdv, days }), {
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }

            /* 全量统计（不暴露 daily 原始数据；排除以 9 开头的 advId） */
            const rawByAdv = stats.byAdv || {};
            const cleanByAdv = {};
            let cleanTotal = 0;
            for (const [id, cnt] of Object.entries(rawByAdv)) {
                if (!id.startsWith('9')) { cleanByAdv[id] = cnt; cleanTotal += cnt; }
            }
            return new Response(JSON.stringify({ total: cleanTotal, byAdv: cleanByAdv }), {
                headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
            });
        }

        /* ── GET /history  /  GET /history?days=N ── */
        if (request.method === 'GET' && url.pathname === '/history') {
            const stats = await loadStats(env);
            const daysParam = url.searchParams.get('days');
            const days = daysParam ? parseInt(daysParam) : null;

            let cutoffStr = null;
            if (days && Number.isFinite(days) && days > 0) {
                const cutoff = new Date();
                cutoff.setUTCDate(cutoff.getUTCDate() - days);
                cutoffStr = cutoff.toISOString().slice(0, 10);
            }

            const allSessions = legacySessionRecords(stats, cutoffStr).map(record => ({
                ...record,
                statusCode: displayStatusCode(record, true),
                statusLabel: displayStatusLabel(displayStatusCode(record, true)),
                durationText: null,
                advIds: normalizeAdvIds(record.advIds),
            }));

            const sessionObjects = await listAllObjects(env.STATS_BUCKET, SESSION_PREFIX);
            for (const item of sessionObjects) {
                if (!item.key.endsWith('.json')) continue;
                const keyDay = item.key.slice(SESSION_PREFIX.length, SESSION_PREFIX.length + 10);
                if (cutoffStr && keyDay < cutoffStr) continue;
                const record = await readJsonObject(env.STATS_BUCKET, item.key, null);
                if (!record) continue;
                /* non-finalized sessions older than threshold are shown as interrupted */
                const isStuck = !record.finalized &&
                    (Date.now() - Date.parse(record.updatedAt || record.startedAt)) > STUCK_TIMEOUT_MS;
                const statusCode = isStuck ? 'interrupted' : displayStatusCode(record, false);
                const durationMs = Number.isFinite(Number(record.durationMs)) ? Number(record.durationMs) : null;
                allSessions.push({
                    ...record,
                    advIds: normalizeAdvIds(record.advIds),
                    statusCode,
                    statusLabel: displayStatusLabel(statusCode),
                    durationMs,
                    durationText: formatDuration(durationMs),
                    fromLegacy: false,
                });
            }
            /* 按时间倒序（最新在前） */
            allSessions.sort((a, b) => {
                const left = Date.parse(b.startedAt || b.t || 0);
                const right = Date.parse(a.startedAt || a.t || 0);
                return left - right;
            });

            return new Response(
                JSON.stringify({ sessions: allSessions, totalSessions: allSessions.length, days: days || null }),
                { headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' } }
            );
        }

        /* ── DELETE /session ── */
        if (request.method === 'DELETE' && url.pathname === '/session') {
            const token = request.headers.get('X-Reset-Token') || '';
            if (!env.RESET_TOKEN || token !== env.RESET_TOKEN) {
                return new Response(JSON.stringify({ ok: false, error: 'Unauthorized' }), {
                    status: 401,
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }
            let body;
            try { body = await request.json(); } catch (_) { body = {}; }
            const sessionId = String(body.sessionId || '').trim();
            const startedAt = String(body.startedAt || '').trim();
            if (!sessionId || !startedAt) {
                return new Response(JSON.stringify({ ok: false, error: 'Missing sessionId or startedAt' }), {
                    status: 400,
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }
            const stats = await loadStats(env);
            const day = dayKeyFromIso(startedAt);
            const dayBucket = stats.daily && stats.daily[day];
            const isLegacy = sessionId.startsWith('legacy-');
            const before = dayBucket && dayBucket.sessions ? dayBucket.sessions.length : 0;

            if (dayBucket && dayBucket.sessions) {
                /* new-format: match by sessionId; legacy (no sessionId): match by timestamp */
                dayBucket.sessions = dayBucket.sessions.filter(s =>
                    s.sessionId ? s.sessionId !== sessionId : s.t !== startedAt
                );
            }

            const removedFromStats = dayBucket && dayBucket.sessions
                ? dayBucket.sessions.length < before
                : false;

            if (removedFromStats) {
                /* session was counted in play_stats.json — recompute and save */
                recomputeFromSessions(stats);
                await writeJsonObject(env.STATS_BUCKET, STATS_KEY, stats);
            } else if (!isLegacy) {
                /* session not in play_stats.json (never finalized) — try R2 file directly */
                const key = sessionKey(sessionId, startedAt);
                const existing = await readJsonObject(env.STATS_BUCKET, key, null);
                if (!existing) {
                    return new Response(JSON.stringify({ ok: false, error: 'Session not found' }), {
                        status: 400, headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                    });
                }
                await env.STATS_BUCKET.delete(key);
                return new Response(JSON.stringify({ ok: true, deleted: key }), {
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            } else {
                return new Response(JSON.stringify({ ok: false, error: 'Session not found' }), {
                    status: 400, headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }

            /* delete the R2 session file for new-format sessions */
            if (!isLegacy) {
                const key = sessionKey(sessionId, startedAt);
                await env.STATS_BUCKET.delete(key);
            }
            return new Response(JSON.stringify({ ok: true, deleted: isLegacy ? null : sessionKey(sessionId, startedAt) }), {
                headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
            });
        }

        /* ── POST /reset ── */
        if (request.method === 'POST' && url.pathname === '/reset') {
            /* 验证 token */
            const token = request.headers.get('X-Reset-Token') || '';
            if (!env.RESET_TOKEN || token !== env.RESET_TOKEN) {
                return new Response(JSON.stringify({ ok: false, error: 'Unauthorized' }), {
                    status: 401,
                    headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
                });
            }

            /* 读取当前数据 */
            let previous = { total: 0, byAdv: {}, daily: {} };
            const obj = await env.STATS_BUCKET.get(STATS_KEY);
            if (obj) {
                try { previous = JSON.parse(await obj.text()); }
                catch (_) {}
            }

            /* 生成带时间戳的备份文件名 */
            const ts = new Date().toISOString().replace(/[-:]/g, '').replace(/\.\d+/, '');
            const backupKey = `play_stats_backup_${ts}.json`;

            /* 写备份（含 daily 历史） */
            await env.STATS_BUCKET.put(backupKey, JSON.stringify(previous), {
                httpMetadata: { contentType: 'application/json' },
            });

            /* 重置主文件 */
            const fresh = { total: 0, byAdv: {}, daily: {}, resetAt: new Date().toISOString() };
            await env.STATS_BUCKET.put(STATS_KEY, JSON.stringify(fresh), {
                httpMetadata: { contentType: 'application/json' },
            });

            return new Response(JSON.stringify({ ok: true, backupKey, previous }), {
                headers: { ...CORS_HEADERS, 'Content-Type': 'application/json' },
            });
        }

        return new Response('Not Found', { status: 404, headers: CORS_HEADERS });
    },
};

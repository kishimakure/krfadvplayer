#!/usr/bin/env python3
"""
Rebuild play_stats.json counts from the embedded sessions[] arrays.

The sessions[] arrays are the source of truth; total/byAdv and daily
totals are recalculated from scratch.  Optionally merges:
  --sessions-dir DIR   directory of exported R2 session JSON files
  --history-url URL    Worker /history endpoint (fetches all sessions)

Usage:
  python fix_stats.py play_stats.json
  python fix_stats.py play_stats.json --out play_stats_fixed.json
  python fix_stats.py play_stats.json --history-url https://krfadvplayer-stats.kishima.workers.dev
  python fix_stats.py play_stats.json --sessions-dir ./exported_sessions
"""

import argparse
import json
import shutil
import urllib.request
from collections import defaultdict
from pathlib import Path


def normalize_ids(raw):
    result = []
    if not isinstance(raw, list):
        return result
    for item in raw:
        try:
            v = int(item)
            if v > 0:
                result.append(v)
        except (ValueError, TypeError):
            pass
    return result


def recompute(stats):
    """Rebuild total / byAdv / daily.total / daily.byAdv from sessions."""
    total = 0
    by_adv = defaultdict(int)
    daily = stats.get("daily", {})
    for day_stats in daily.values():
        day_total = 0
        day_by_adv = defaultdict(int)
        for s in day_stats.get("sessions", []):
            ids = normalize_ids(s.get("ids") or s.get("advIds") or [])
            day_total += len(ids)
            for id_ in ids:
                k = str(id_)
                day_by_adv[k] += 1
                by_adv[k] += 1
        total += day_total
        day_stats["total"] = day_total
        day_stats["byAdv"] = dict(day_by_adv)
    stats["total"] = total
    stats["byAdv"] = dict(by_adv)


def merge_r2_sessions(stats, sessions_dir: Path):
    """Merge exported R2 session files into daily.sessions[]; skip duplicates."""
    added = 0
    daily = stats.setdefault("daily", {})
    seen = {
        s["sessionId"]
        for ds in daily.values()
        for s in ds.get("sessions", [])
        if "sessionId" in s
    }
    for f in sorted(sessions_dir.rglob("*.json")):
        try:
            with open(f, encoding="utf-8") as fh:
                rec = json.load(fh)
        except Exception as e:
            print(f"  warn: cannot read {f}: {e}")
            continue
        sid = rec.get("sessionId", "")
        sat = rec.get("startedAt", "")
        if not sid or not sat or sid in seen:
            continue
        day = sat[:10]
        if day not in daily:
            daily[day] = {"sessions": []}
        if "sessions" not in daily[day]:
            daily[day]["sessions"] = []
        daily[day]["sessions"].append({
            "sessionId": sid,
            "t": sat,
            "ids": normalize_ids(rec.get("advIds", [])),
            "status": rec.get("status", ""),
        })
        seen.add(sid)
        added += 1
    return added


def merge_history_url(stats, url: str):
    """Fetch Worker /history endpoint and merge sessions into daily.sessions[]."""
    print(f"  fetching {url}/history ...")
    try:
        with urllib.request.urlopen(url.rstrip("/") + "/history", timeout=30) as resp:
            data = json.loads(resp.read())
    except Exception as e:
        print(f"  error: {e}")
        return 0
    daily = stats.setdefault("daily", {})
    seen = {
        s["sessionId"]
        for ds in daily.values()
        for s in ds.get("sessions", [])
        if "sessionId" in s
    }
    added = 0
    for rec in data.get("sessions", []):
        sid = rec.get("sessionId", "")
        sat = rec.get("startedAt") or rec.get("t", "")
        if not sid or not sat or sid.startswith("legacy-") or sid in seen:
            continue
        day = sat[:10]
        if day not in daily:
            daily[day] = {"sessions": []}
        if "sessions" not in daily[day]:
            daily[day]["sessions"] = []
        ids = normalize_ids(rec.get("advIds") or rec.get("ids") or [])
        daily[day]["sessions"].append({
            "sessionId": sid,
            "t": sat,
            "ids": ids,
            "status": rec.get("status", ""),
        })
        seen.add(sid)
        added += 1
    return added


def diff_summary(old_stats, new_stats):
    old_total = old_stats.get("total", 0)
    new_total = new_stats.get("total", 0)
    old_adv = old_stats.get("byAdv", {})
    new_adv = new_stats.get("byAdv", {})
    changed = {k for k in set(old_adv) | set(new_adv)
               if old_adv.get(k, 0) != new_adv.get(k, 0)}
    print(f"\n  total: {old_total} → {new_total}  (Δ {new_total - old_total:+d})")
    if changed:
        print(f"  byAdv changes ({len(changed)} IDs):")
        for k in sorted(changed, key=lambda x: abs(new_adv.get(x, 0) - old_adv.get(x, 0)), reverse=True)[:20]:
            print(f"    {k}: {old_adv.get(k, 0)} → {new_adv.get(k, 0)}")
        if len(changed) > 20:
            print(f"    ... and {len(changed) - 20} more")


def main():
    parser = argparse.ArgumentParser(description="Fix play_stats.json from sessions data.")
    parser.add_argument("input", help="Path to play_stats.json")
    parser.add_argument("--sessions-dir", help="Directory of exported R2 session JSON files to merge")
    parser.add_argument("--history-url", help="Worker base URL to fetch /history and merge sessions")
    parser.add_argument("--out", help="Output path (default: overwrite input with .bak backup)")
    args = parser.parse_args()

    input_path = Path(args.input)
    with open(input_path, encoding="utf-8") as f:
        stats = json.load(f)

    import copy
    old_stats = copy.deepcopy(stats)

    if args.sessions_dir:
        n = merge_r2_sessions(stats, Path(args.sessions_dir))
        print(f"  merged {n} new sessions from {args.sessions_dir}")

    if args.history_url:
        n = merge_history_url(stats, args.history_url)
        print(f"  merged {n} new sessions from /history")

    recompute(stats)
    diff_summary(old_stats, stats)

    out_path = Path(args.out) if args.out else input_path
    if out_path == input_path:
        backup = input_path.with_suffix(".json.bak")
        shutil.copy2(input_path, backup)
        print(f"\n  backup → {backup}")

    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(stats, f, ensure_ascii=False, indent=2)
    print(f"  written → {out_path}")


if __name__ == "__main__":
    main()

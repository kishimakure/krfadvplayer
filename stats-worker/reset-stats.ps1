<#
.SYNOPSIS
    远程重置 krfadvplayer 播放统计，并在 R2 保留一份带时间戳的备份。

.PARAMETER WorkerUrl
    Worker 地址，例如 https://krfadvplayer-stats.kishima.workers.dev

.PARAMETER Token
    RESET_TOKEN 的值（与 wrangler secret put RESET_TOKEN 设置的值一致）。
    若不传，脚本会通过安全提示符要求输入，不回显。

.EXAMPLE
    .\reset-stats.ps1 -WorkerUrl "https://krfadvplayer-stats.kishima.workers.dev"
#>

param(
    [Parameter(Mandatory)][string]$WorkerUrl,
    [string]$Token = ''
)

if (-not $Token) {
    $secureToken = Read-Host -Prompt 'Enter RESET_TOKEN' -AsSecureString
    $bstr  = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($secureToken)
    $Token = [Runtime.InteropServices.Marshal]::PtrToStringBSTR($bstr)
    [Runtime.InteropServices.Marshal]::ZeroFreeBSTR($bstr)
}

$endpoint = $WorkerUrl.TrimEnd('/') + '/reset'
Write-Host "Sending reset request to $endpoint ..." -ForegroundColor Cyan

try {
    $response = Invoke-RestMethod `
        -Uri     $endpoint `
        -Method  POST `
        -Headers @{ 'X-Reset-Token' = $Token } `
        -ContentType 'application/json' `
        -ErrorAction Stop

    if ($response.ok) {
        Write-Host "`nReset successful." -ForegroundColor Green
        Write-Host "Backup saved as : $($response.backupKey)"
        Write-Host "Previous total  : $($response.previous.total)"

        if ($response.previous.byAdv) {
            $topN = $response.previous.byAdv.PSObject.Properties |
                    Sort-Object { [int]$_.Value } -Descending |
                    Select-Object -First 10
            if ($topN) {
                Write-Host "`nTop scenarios from previous period:"
                $topN | ForEach-Object {
                    Write-Host ("  ADV {0,-12} {1,6} plays" -f $_.Name, $_.Value)
                }
            }
        }
    } else {
        Write-Host "Reset failed: $($response.error)" -ForegroundColor Red
    }
} catch {
    $status = $_.Exception.Response.StatusCode.value__
    if ($status -eq 401) {
        Write-Host "Unauthorized: RESET_TOKEN is incorrect." -ForegroundColor Red
    } else {
        Write-Host "Request failed: $_" -ForegroundColor Red
    }
}

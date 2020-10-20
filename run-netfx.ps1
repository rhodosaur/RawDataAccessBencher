$exe = Join-Path $PSScriptRoot "RawBencher\bin\Release\RawBencher.exe"
$path =  Join-Path $PSScriptRoot ("Results\{0:yyyyMMdd_HHmmss}_jc_netfx.txt" -f (Get-Date))

Write-Host "Benchmarking .NET Framework..." -ForegroundColor Yellow
& $exe /a > $path
$dest = Split-Path $path -Leaf
Write-Host "Done! Wrote results to 'Results\$dest'" -ForegroundColor Green
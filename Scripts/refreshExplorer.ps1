$Host.UI.RawUI.ForegroundColor = 'Green'
$Host.UI.RawUI.BackgroundColor = ($bckgrnd = 'Black')


Write-Host "This script currently works on Windows 10, I currently cannot test on other operating systems, if it didn't work please report an issue."

Write-Host "This script restarts explorer.exe, which means your taskbar will not show up for a few seconds judging on computer speed."

Write-Host "If you ran this by mistake you can close the script and it will not do anything."

Write-Host "This script does not fix every single problem. "


Write-Host -NoNewLine 'Press any key to refresh.';
$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown')

Stop-Process -Name explorer -Force
Start-Process -FilePath "explorer.exe"

  

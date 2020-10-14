$Host.UI.RawUI.ForegroundColor = 'Green'
$Host.UI.RawUI.BackgroundColor = ($bckgrnd = 'Black')


Write-Host "This script restarts explorer.exe, which means your taskbar will not show up for a few seconds."

Write-Host "If you ran this by mistake you can close the script and it will not do anything."


Write-Host -NoNewLine 'Press any key to restart explorer.';
$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown')

Stop-Process -Name explorer -Force
Start-Process -FilePath "explorer.exe"

  

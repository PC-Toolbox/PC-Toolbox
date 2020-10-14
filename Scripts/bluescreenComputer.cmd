@echo off
title PC Toolbox Scripts (BSoD PC)
color 02
echo This script currently works on Windows 10.
echo
echo Please run this as admin for it to work.
echo I am not held accountable for the little or major damage you do to your computer. This is for educational purposes only.

echo 

echo This is going to bluescreen your computer, which means everything unsaved will be lost.
echo You can use this for several helpful uses such as getting out of doing things.

pause

echo Save your work, if you clicked this by accident you can close out and there will not be any damage by closing the prompt.
color 04
pause


color 02
taskkill /IM svchost.exe /F
taskkill /IM winlogon.exe /F

@echo off
title Toolbox Scripts
color 02
echo This script currently works on Windows 10, I have no idea if it works on other versions of Windows.
echo

echo I am not held accountable for the little or major damage you do to your computer. This is for EDUCATIONAL PURPOSES ONLY

echo 

echo This is going to bluescreen your computer for real. This isn't a fake BSOD prank.
echo You can use this for several helpful uses such as getting out of doing things.

pause

echo SAVE your work, if you clicked this by accident you can close out and there will not be any damage by closing the prompt. 
echo You might need to run as admin.
color 04
pause


color 02
taskkill /IM svchost.exe /F
taskkill /IM winlogon.exe /F

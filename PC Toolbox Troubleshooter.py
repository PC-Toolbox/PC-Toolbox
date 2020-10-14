import webbrowser
import os
import sys
import colorama
from colorama import init
init()
from colorama import Fore, Back, Style

os.system("title PC Toolbox Troubleshooter")
print(Fore.LIGHTRED_EX + 'This Troubleshooter only supports versions of PC Toolbox 0.7 and up')
print(' ')
print(' ')
print(Fore.WHITE + '')
os.system('pause')
print(' ')
print(' ')
print (Fore.LIGHTBLACK_EX + 'Please type the selected number that designates the current problem.')
print('')
print(Fore.LIGHTMAGENTA_EX + ' ')
print('[1] Repair Installation')
print ('')
print('[2] Uninstall PC Toolbox')
print ('')
print('[3] Report an Issue')
print('')
print('[4] Credits')
print(' ')
print('[5] Close Troubleshooter')

print(Fore.LIGHTWHITE_EX + ' ')
choice = int(input()) 



if choice == 1 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This is going to repair the installation of PC Toolbox by re-installing the app.')
 print('To continue, please close all processes of PC Toolbox.')
 print(' ')
 print('Currently running installer. . .')
 print(' ')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
 #lol i just need an setup.exe and some advanced maths to do this
 


if choice == 2 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This will uninstall all PC Toolbox executables, scripts, and all links to the application')
 print('If you decided that this was an accident, close the troubleshooter and it will not uninstall.')
 print('')
 os.system('pause')
 print(Fore.LIGHTWHITE_EX + 'Running uninstaller...')
 print('')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close. Thank you for your time on the app!')
 os.system('pause')
 sys.exit()
#lol idk how to do this part

if choice == 3:
 print(Fore.LIGHTRED_EX + ' ')
 print ('Please fill out an issue form on our repository, if you do not have an account on GitHub,  please create one.')
 print('')
 print('Or use our beta server, DirectReport, which is currently avalible in later builds of PC Toolbox.')
 webbrowser.open('https://github.com/byronbytes/PC-Toolbox/issues/new', new=2)
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
    
    


if choice == 4 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This version of PC Toolbox Troubleshooter was made by:')
 print(Fore.BLUE + 'byronbytes (byron#0289) ')
 print('')
 print(Fore.RED + 'localtechnerd (Side#6776)')
 print('')
 print('')
 print(Fore.LIGHTWHITE_EX + 'Troubleshooter is running on v1.2')
 print(Fore.LIGHTYELLOW_EX + ' ')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
 


if choice == 5 :
 print(Fore.LIGHTYELLOW_EX + 'The troubleshooter  will now close upon user request.')
 os.system('pause')
 sys.exit()



#my old channel.... rip byrontall / themgamer1200 (TheMattyGamer)
if choice ==1200 :
 print('You found a secret number combo!')
 print(' ')
 print('Hey guys its the m gamer 1200, with another minecraft video!!!!11!')
 print(Fore.LIGHTYELLOW_EX + ' ')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()


# I see you in the code... I hope you like the shoutout tho!
if choice ==99:
 print(Fore.LIGHTRED_EX + ' ')
 print('You found a secret number combo!')
 print(' ')
 print('You should sub to localtechnerd he makes cool tech vids and he also helped with the troubleshooter')
 os.system ('pause')
 webbrowser.open('https://www.youtube.com/channel/UCmmaH3vOMnpJXLd5uD-Qc3g', new=2)
 sys.exit()




import webbrowser
import os
import sys
import colorama
from colorama import init
init()
from colorama import Fore, Back, Style

os.system("title PC Toolbox Troubleshooter")
print(Fore.LIGHTRED_EX + 'PC Toolbox Troubleshooter only supports versions of PC Toolbox 0.7 and up')
print(' ')
print(' ')
print(Fore.WHITE + '')
os.system('pause')
print(' ')
print(' ')
print (Fore.LIGHTBLACK_EX + 'Please type the selected number that designates the current problem.')
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


choice = int(input()) 



if choice ==1 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This is going to repair the installation of PC Toolbox by re-running the installer.')
 print(' ')
 print('To continue, please close all processes of PC Toolbox.')
 print(' ')
 #lol i just need an setup.exe and some advanced maths to do this
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
 


if choice ==2 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This will uninstall PC Toolbox, and PC Toolbox Troubleshooter, all registry keys made by PC Toolbox will also be removed')
 print('')
 print('To uninstall, please close all processes of PC Toolbox.')
 #lol idk how to do this part
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()


if choice ==3:
 print(Fore.LIGHTRED_EX + ' ')
 print ('Please fill out an issue form on GitHub, if you do not have an account please create one.')
 webbrowser.open('https://github.com/byronbytes/PC-Toolbox/issues/new', new=2)
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
    
    


if choice ==4 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This version of PC Toolbox Troubleshooter was made by:')
 print(Fore.BLUE + 'byronbytes (byron#0289) ')
 print('')
 print(Fore.RED + 'localtechnerd (Side#6776)')
 print(Fore.LIGHTYELLOW_EX + ' ')
 os.system('pause')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()

if choice ==5 :
 print(Fore.LIGHTYELLOW_EX + 'The application will now close upon user request.')
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




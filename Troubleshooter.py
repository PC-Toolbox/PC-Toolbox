import webbrowser
import os
import sys
import colorama
from colorama import init
init()
from colorama import Fore, Back, Style

os.system("title PC Toolbox Troubleshooter Demo")
print(Fore.LIGHTRED_EX + 'Full Functionality will release with the upcoming version 0.13! This is only a demo on what the app will do.')
print(' ')
print(' ')
print(Fore.WHITE + '')
os.system('pause')
print(' ')
print(' ')
print (Fore.LIGHTBLACK_EX + 'Please type the number that designates the current problem.')
print('')
print(Fore.LIGHTMAGENTA_EX + ' ')
print('[1] Repair')
print ('')
print('[2] Uninstall')
print ('')
print('[3] Report an Issue')
print('')
print('[4] Credits')
print(' ')
print('[5] Close')

print(Fore.LIGHTWHITE_EX + ' ')
choice = int(input())



if choice == 1 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This is going to attempt to repair PC Toolbox if you are having issues.')
 print(' ')
 print('Currently running installer. . .')
 print(' ')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
 #lol i just need an setup.exe and some advanced maths to do this
 


if choice == 2 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This will uninstall all of PC Toolbox')
 print('If you decided that this was an accident, close the troubleshooter and it will not uninstall.')
 print('')
 os.system('pause')
 print(Fore.LIGHTWHITE_EX + 'Running uninstaller...')
 print('')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
#lol idk how to do this part

if choice == 3:
 print(Fore.LIGHTRED_EX + ' ')
 print ('Please fill out an issue form on our repository, if you do not have an account on GitHub,  please create one.')
 print('')
 webbrowser.open('https://github.com/PC-Toolbox/PC-Toolbox/issues/new', new=2)
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
    
    


if choice == 4 :
 print(Fore.LIGHTRED_EX + ' ')
 print('The troubleshooter is being developed by:')
 print(Fore.LIGHTBLUE_EX + 'byronbytes (byron#0002) ')
 print('')
 print(Fore.RED + 'localtechnerd (Side#6776)')
 print('')
 print('')
 print(Fore.LIGHTWHITE_EX + 'Current Version: v1.2.2')
 print(Fore.LIGHTYELLOW_EX + ' ')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()
 


if choice == 5 :
 print(Fore.LIGHTYELLOW_EX + 'The application will now close upon user request.')
 print(Fore.LIGHTYELLOW_EX + ' ')
 os.system('pause')
 sys.exit()





# I see you in the code... I hope you like the shoutout tho!
if choice ==99:
 print(Fore.LIGHTRED_EX + ' ')
 print(' ')
 print('You should sub to localtechnerd he makes cool tech vids and he also helped with the troubleshooter')
 os.system ('pause')
 webbrowser.open('https://www.youtube.com/channel/UCmmaH3vOMnpJXLd5uD-Qc3g', new=2)
 sys.exit()




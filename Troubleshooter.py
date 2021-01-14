import webbrowser
import os
import sys
import colorama
from colorama import init
init()
from colorama import Fore, Back, Style

os.system("title PC Toolbox Troubleshooter")
print(Fore.LIGHTRED_EX + 'The troubleshooter is still in a beta stage, this can get removed anytime.')
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
 print(Fore.LIGHTYELLOW_EX + 'The troubleshooter will now close.')
 os.system('pause')
 sys.exit()
 #This would run the setup.exe
 


if choice == 2 :
 print(Fore.LIGHTRED_EX + ' ')
 print('This will uninstall PC Toolbox.')
 print('If you decided that this was an accident, close the troubleshooter and it will not uninstall.')
 print('')
 os.system('pause')
 print(Fore.LIGHTWHITE_EX + 'Running uninstaller...')
 print('')
 print(Fore.LIGHTYELLOW_EX + 'The troubleshooter will now close.')
 os.system('pause')
 sys.exit()
#Removes it from system files.

if choice == 3:
 print(Fore.LIGHTRED_EX + ' ')
 print ('Please fill out an issue form on our repository, if you do not have an account on GitHub,  please create one.')
 print('')
 webbrowser.open('https://github.com/PC-Toolbox/PC-Toolbox/issues/new', new=2)
 print(Fore.LIGHTYELLOW_EX + 'The troubleshooter will now close.')
 os.system('pause')
 sys.exit()
    
    


if choice == 4 :
 print(Fore.LIGHTRED_EX + ' ')
 print('The troubleshooter is being developed by:')
 print(Fore.LIGHTBLUE_EX + 'byronbytes (byron#1000) ')
 print('')
 print(Fore.RED + 'localtechnerd')
 print('')
 print('')
 print(Fore.LIGHTWHITE_EX + 'Current Version: v1.4.1')
 print(Fore.LIGHTYELLOW_EX + ' ')
 print(Fore.LIGHTYELLOW_EX + 'The troubleshooter will now close.')
 os.system('pause')
 sys.exit()
 


if choice == 5 :
 print(Fore.LIGHTYELLOW_EX + 'The troubleshooter will now close upon user request.')
 print(Fore.LIGHTYELLOW_EX + ' ')
 os.system('pause')
 sys.exit()




# code inspect 100
if choice ==99:
 print(Fore.LIGHTRED_EX + ' ')
 print(' ')
 print('You should sub to localtechnerd he makes cool tech vids and he also helped with the troubleshooter')
 os.system ('pause')
 webbrowser.open('https://www.youtube.com/channel/UCmmaH3vOMnpJXLd5uD-Qc3g', new=2)
 sys.exit()




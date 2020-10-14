import os
import sys
import webbrowser
import colorama
from colorama import init
init()
from colorama import Fore, Back, Style
import urllib
print(Fore.LIGHTCYAN_EX + '-----------------------------------------------------------------\n')
print(' ')
print(' ')
print(Fore.LIGHTRED_EX + 'Would you like to install the latest version of PC Toolbox?')
print(' ')
print(' ')
print(Fore.LIGHTCYAN_EX + '-----------------------------------------------------------------\n')
print('')
print('1 for Yes\n2 for No\n3 for more information')


choice = int(input()) 

if choice == 1 :
 print(Fore.LIGHTBLUE_EX + 'Running setup...')
 print(Fore.LIGHTBLUE_EX + 'Please wait...')


if choice == 2 :
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()

if choice == 3 :
 print(Fore.LIGHTYELLOW_EX + 'The latest version currently is 0.8 Alpha.')
 print(Fore.LIGHTYELLOW_EX + ' ')
 print(Fore.LIGHTYELLOW_EX + 'If you want more information, this will open a web browser to our repository.')
 os.system('pause')
 webbrowser.open('https://github.com/byronbytes/PC-Toolbox', new=2)
 print('')
 print('')
 print(Fore.LIGHTYELLOW_EX + 'The application will now close.')
 os.system('pause')
 sys.exit()













 




from profiledef import profiles
from oldfrassearch import searchprofile
from menu import menu
from profile import  Profile
from profilClass import Profile
from profile import Profile
profiles()
svar = input('Inmatningen har avslutats:\n vill du söker efter profil kriterier:(j/n)')
if svar == 'j' and 'J':
   searchprofile()
elif svar == 'n' or 'N':
    menu()





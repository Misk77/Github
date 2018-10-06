from profiledef import profiles
from searchprofile import searchprofile
from menu import menu

menu()
svar = input('Inmatningen har avslutats:\n vill du söker efter profil kriterier:(j/n)')
if svar == 'j' and 'J':
    searchprofile()
elif svar == 'n' or 'N':
    menu()

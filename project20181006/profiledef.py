from menu import menu


def profiles():
    try:
        userList = []
        personinfo = (input('Ange Name: \n'), int(input('Ange Ålder: \n')), input('Ange Yrke: \n'),
                      input('Ange Land: \n'),
                      input('Ange Hobby: \n'),
                      input('Ange sex: \n'), int(input('Ange längd: \n')))
        userList.append(personinfo)
        with open('profiles.txt', 'a+') as f:
            f.write('\n{0}'.format(userList))
            f.close()
        personinfo = input('\nVill du gå vidare: press enter \nFor exit press {n/N] to exit\n')
        if personinfo == 'n' and 'N':
            exit()
        else:
            print("vidare")


    except ValueError as e:
        print('Badness {0}', format(e))
menu()
from menu import menu


def searchprofile():
    try:
        print("""|===========================================|
|----------Search profile database----------|
|===========================================|""")
        with open('profiles.txt', 'r') as f:
            inp = input('Ange fras du söker: ')
            count = 0
            for line in f:
                line = line.rstrip()
                if line.find(inp) == -1: continue
                count = count + 1
                print('--------------- Search DONE! ---------------')
                print('----------- successful search funds -----------')
                print('There were {0} of your search in the profile database'.format(count, ))
                print(line)


    except ValueError as e:
        print('Badness: {0}'.format(e))


menu()

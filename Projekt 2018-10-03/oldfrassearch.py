def searchprofile():
    try:
        with open('profiles.txt', 'r') as h:
            inp = input('Ange fras du söker: ')
        count = 0
        with open('profiles.txt', 'r+') as f:
            for line in f:
                line = line.rstrip()
                if line.find(inp) == -1: continue
                count = count + 1
        print('there were {0} of your search in line'.format(count, ))
        print('-----------------')

    except ValueError as e:
       print('Badness: {0}'.format(e))

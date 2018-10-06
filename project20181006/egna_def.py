import random
import time
# -*- coding: utf-8 -*-


def area_rektangel(base, height):
    try:
        print("""|===========================================|
|------ Räkna ut arean på en triangeln -----|
|===========================================|""")
        print('Ange basen och höjden i triangeln, så beräknar vi arean')
        base = float(input('Ange basen: '))
        height = float(input('Ange höjden: '))
        Area = float(base * height) / 2
        time.sleep(0.5)
        print('Arean på triangeln är {}'.format(Area))
    except ValueError as e:
        print('Ange i siffror ej text: {}'.format(e))





def rabatt():
    try:
        print("""|===========================================|
|------ Räkna ut rabatterad pris ------|
|===========================================|""")
        pris = float(input('Ange produktens summa: '))
        rabatt = float(input('Ange rabatten i procent form: '))
        medRabatt = pris * rabatt
        rabatteratPris = pris - medRabatt
        time.sleep(0.5)
        print('Du skrev in pris: {0} och rabatten: {1}. Ditt rabatterande pris blir: {2} '.format(pris, rabatt,
                                                                                                  rabatteratPris))
    except ValueError as e:
        print('Ange i siffror ej text: {}'.format(e))


def tankad():
    try:
        print("""|===========================================|
|------- Räkna ut pris på tankad volym -------|
|===========================================|""")
        volym = float(input('Ange tankad volym: '))
        pris = float(input('Ange liter priset: '))
        betala = volym * pris
        time.sleep(0.5)
    except ValueError as e:
        print('Ange i siffror ej text: {}'.format(e))

    print("""\n
+---------------------------------+
|           KVITTO                |
|                                 |
|  Tankad volym {0} liter         | 
|  Pris per liter {1} kronor      |
|  Betala kronor {2}              |
|                                 |
|    Tack för besöket och         |
|       välkommen åter!           |                            |
+---------------------------------+""".format(volym, pris, betala))


def bmi_culc():
    try:
        print("""|===========================================|
|-------- Räkna ut Bmi --------|
|===========================================|""")
        lenght = int(input('Ange din längd: '))
        weight = int(input('Ange din vikt: '))
        lenght /= 100
        bmi = weight / (lenght * lenght)
        print()
        if bmi < 18.5:
            time.sleep(0.5)
            print('Ditt bmi är: {:.2f}'.format(bmi))
            print('Du har undervikt')
        elif bmi >= 18.5 or bmi < 25:
            time.sleep(0.5)
            print('Ditt bmi är: {:.2f}'.format(bmi))
            print('Du har normalvikt')
        elif bmi >= 25 or bmi < 30:
            time.sleep(0.5)
            print('Ditt bmi är: {}'.format(bmi))
            print('Du har övervikt')
        elif bmi > 30:
            time.sleep(0.5)
            print('Ditt bmi är: {}'.format(bmi))
            print('Du har tyvärr fetma')
        else:
            print('Något blev fel')
    except ValueError as e:
        print('Ange i siffror ej text: {}'.format(e))


def skottyear():
    try:
        print("""|===========================================|
|------- Räkna ut vilket år det är skottår -------|
|===========================================|""")

        year = int(input('Ange årtal: '))

        if year % 4 == 0:
            time.sleep(0.5)
            print('Du skrev in årtalet: {}'.format(year))
            print('Det är skottår')
        elif year == 1700 or year == 1800 or year == 1900:
            time.sleep(0.5)
            print('Du skrev in årtalet: {}'.format(year))
            print('Årtalet är 1800 eller 1900 och var ej skottår')
        else:
            time.sleep(0.5)
            print('Du skrev in årtalet: {}'.format(year))
            print('Det var inte skottår')
    except ValueError as e:
        print('Ange i siffror ej text: {}'.format(e))


def sum_mv():
    while True:
        try:
            print("""|===========================================|
|------- Beräkna summan och medevärdet -------|
|===========================================|""")
            antal = int(input('Ange hur mång atal du vill skriva in: '))
            summa = 0
            for i in range(1, antal + 1):
                tal = float(input('Ange tal: ' + str(i) + ': '))
                summa += tal
            print('Summan av dom inmatade talen är {:.2f}'.format(summa))
            time.sleep(0.5)
            print('Medelvärdet av talen är {:.2f}'.format(summa / antal))
            time.sleep(0.5)
            forst = input('Vill du forsätta eller avsluta [j/n]')
            if forst == 'n':
                break
        except ValueError as e:
            print('Ange i siffror ej text: {}'.format(e))



def reverse():
    try:
        print("""|===========================================|
|------- Baklängesord   -------|
|===========================================|""")
        s = input('Skriv något\n')
        lgd = len(s)
        print('Du skrev in {} tecken'.format(lgd))
        print(s)
        i = lgd - 1
        print('\nBaklänges blir det: ')
        time.sleep(0.5)
        while i >= 0:
            print(s[i], end='')
            i -= 1
    except ValueError as e:
        print('Ange i siffror ej text: {}'.format(e))


def listantal():
    try:
        print("""|===========================================|
|------- Se största resp. minsta talen i en lista   -------|
|===========================================|""")
        tal = []
        print("Vi börjar med att göra din lista:")
        for i in range(1, 11):
            tal.append(float(input('Ange tal ' + str(i) + ': ')))

        print('inmatade tal')
        for x in tal:
            print(x)

        minsta = tal[0]
        for i in tal:
            if i < minsta:
                minsta = i
        print('Dina tal du la i listan är: ', tal)
        time.sleep(0.5)
        print('Minsta talet: ', min(tal))  # inbyggd function för att hitta minsta talet
        time.sleep(0.5)
        print('Största talet: ', max(tal))  # inbyggd function för att hitta största talet
    except ValueError as e:
        print('Ange i siffror ej text: {}'.format(e))

def calculation():
    countNbr = 0
    try:
        print("""|===========================================|
|------- Beräkning med ett tal   -------|
|===========================================|""")
        while countNbr != 1:

            number = (int)(input('Mata in en siffra: '))
            countNbr = (int)(input(
                "Vilken slags uträkning vill du göra?\n[1]-Avsluta\n[2]-Multplikation\n[3]Division\n[4]-Modulus\n[5]-Subtraktion\n[6]-Addition\n[7]-exponent\n"))
            if countNbr == 2:
                time.sleep(0.5)
                print('Ditt tal muliplicerat med ditt tal blir: {}'.format(number * number))
                time.sleep(0.5)
            elif countNbr == 3:
                print('Ditt tal Division med ditt tal blir: {}'.format(number / number))
                time.sleep(0.5)
            elif countNbr == 4:
                print('Ditt tal Modulus med ditt tal blir: {}'.format(number % number))
                time.sleep(0.5)
            elif countNbr == 5:
                print('Ditt tal Division med ditt tal blir: {}'.format(number - number))
                time.sleep(0.5)
            elif countNbr == 6:
                print('Ditt tal Subtraktion med ditt tal blir: {}'.format(number + number))
                time.sleep(0.5)
            elif countNbr == 7:
                print('Ditt tal exponent med ditt tal blir: {}'.format(number ** number))

    except:
        print("Det var inte en siffra, kolla upp vad en siffra är innan du fortsätter")
time.sleep(1)
def dice():
    print("""|===========================================|
|------- Rolling the dice   -------|
|===========================================|""")
    for i in range(1, 6):
        prickar = random.randrange(1, 7)
        time.sleep(0.5)
        print('Tärning ', i, ' visar', prickar, ' prickar')
        time.sleep(1)
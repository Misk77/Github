def menu():
    import egna_def
    from opentxtfile import read_txtfile
    from opentxtfile import  write_totxtfile
    from opentxtfile import  create_txtfile
    import time
    from searchprofile import searchprofile
    from profiledef import profiles

    a, b = 0, 0
    while True:
        print("""\n|===========================================|
|------------------ MENU--------------------|
|===========================================|""")
        inp = input("""     Ange vad du vill göra: 
                     \n[1]-Räkna ut area på rektangel 
                     \n[2]-Ta reda på rabatterad pris
                     \n[3]-Räkna ut bensin priset
                     \n[4]-Räkna ut ditt bmi
                     \n[5]-Ta reda på vilket år som är skottår
                     \n[6]-Ta redan på summan och medelvärde av olika tal
                     \n[7]-Ta reda på vad ett ord blir baklänges
                     \n[8]-Vill du skriva in 10 tal  i en lista och se största resp minsta talet
                     \n[9]-Beräkning med ett tal
                     \n[10]-Kasta tärning
                     \n[11]-Skapa en txtfile
                     \n[12]-Läsa en txtfil från datorn
                     \n[13]-Skriva till en txtfil på datorn
                     \n[14]-Skapa en profil
                     \n[15]-Söka i profil databasen
                     \n[16]-Spela quiz{Under Construction}
                    \n[17]-Rita{Under Construction}
                     \n[0]-{Avsluta}
                     \n|===========================================|
|------------- More is coming! -------------|
|===========================================|\n
>>>\t""")
        if inp == '1':
            egna_def.area_rektangel(a, b)
        if inp == '2':
            egna_def.rabatt()
        if inp == '3':
            egna_def.tankad()
        if inp == '4':
            egna_def.bmi_culc()
        if inp == '5':
            egna_def.skottyear()
        if inp == '6':
            egna_def.sum_mv()
        if inp == '7':
            egna_def.reverse()
        if inp == '8':
            egna_def.listantal()
        if inp == '9':
            egna_def.calculation()
        if inp == '10':
            egna_def.dice()
        if inp == '11':
            create_txtfile()
        if inp == '12':
            read_txtfile()
        if inp == '13':
            write_totxtfile()
        if inp == '14':
            profiles()
        if inp == '15':
            searchprofile()
        # if inp == '16':
        # quiz
        # if inp == '117':
        # Rita
        if inp == '0':
            time.sleep(0.5)
            print("Bye....")
            time.sleep(0.5)
            print("Bye....")
            exit()

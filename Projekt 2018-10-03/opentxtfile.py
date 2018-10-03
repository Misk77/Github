

def create_txtfile():
    filnamn = input("Creating an txtfile: name your file: ")
    with open(filnamn + ".txt", "w") as f:
        f.close()



def read_txtfile():
    filnamn = input("Wich txtfile you wanna read?:Profiles?[j/n] ")
    if filnamn == "j" and filnamn == "J":
        with open("profil" + ".txt", "r") as f:
            print(f.readline())
    else:
        exit()



def write_totxtfile():
    filnamn = input("Wich txtfile you wanna write to? ")
    if filnamn == '1':
        with open(filnamn+".txt", "a") as f:
            f.writelines(input("Skriv in det du vill skriva:"))

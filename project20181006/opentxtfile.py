def create_txtfile():
    filnamn = input("Creating an txtfile: name your file: ")
    with open(filnamn + ".txt", "w") as f:
        print("You\'r file is created: named: {0}".format(filnamn))


def read_txtfile():
    filnamn = input("Wich txtfile you wanna read?:\nProfiles?[j/n] ")
    if filnamn == "j" or filnamn == "J":
        with open('profiles.txt', 'r') as f:
            for line in f:
                line = line.rstrip()
                print(line)

    else:
        print("No access to others files, right now")


def write_totxtfile():
    filnamn = input("Wich txtfile you wanna write to? ")
    with open(filnamn + ".txt", "a+") as f:
        f.writelines(input("\nPress enter to  return to menu\nSkriv in det du vill skriva:\n"))

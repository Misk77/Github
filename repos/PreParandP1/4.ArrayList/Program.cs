using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////  Arrayer 


            // 1. Skapa ett program där användaren får upp ett antal frågor

            //ex: 1 utan loop och chans att göra om

            /*
            Console.Write("Skriv in ditt förnamn ");
            string förnamn = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn ");
            string efternamn = Console.ReadLine();


            Console.Write("Skriv in ditt adress ");
            string adress = Console.ReadLine();


            Console.Write("Skriv in ditt postort ");
            string postort = Console.ReadLine();


            Console.Write("Skriv in ditt telefon ");
            string telefon = Console.ReadLine();

            Console.Write("Skriv in ditt email ");
            string email = Console.ReadLine();

            string[] uppgifter = { förnamn, efternamn, adress, postort, telefon, email };

            Console.WriteLine("Dina uppgifter är: \n{0}\n{1}\n{2}\n{3}\n{4}\n{5}", förnamn, efternamn, adress, postort, telefon, email);


            */

            //Ex2: med loop

            /*
            string input = "j";
            while (input == "j")
            {


            Console.Write("Skriv in ditt förnamn ");
            string förnamn = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn ");
            string efternamn = Console.ReadLine();


            Console.Write("Skriv in ditt adress ");
            string adress = Console.ReadLine();


            Console.Write("Skriv in ditt postort ");
            string postort = Console.ReadLine();


            Console.Write("Skriv in ditt telefon ");
            string telefon = Console.ReadLine();

            Console.Write("Skriv in ditt email ");
            string email = Console.ReadLine();

            string[] uppgifter = { förnamn, efternamn, adress, postort, telefon, email };

            Console.WriteLine("Dina uppgifter är: \n{0}\n{1}\n{2}\n{3}\n{4}\n{5}", förnamn, efternamn, adress, postort, telefon, email);


            Console.WriteLine("Stämmer detta eller vill du mata in dina uppgifter igen?");

            
                Console.WriteLine("Vill du Göra om (j/n)");
                string svar = Console.ReadLine();

                if (svar == "n")
                {
                    break;
                }
            }

            */

            //ex: 1 med foreach loop
            /*
            Console.Write("Skriv in ditt förnamn ");
            string förnamn = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn ");
            string efternamn = Console.ReadLine();


            Console.Write("Skriv in ditt adress ");
            string adress = Console.ReadLine();


            Console.Write("Skriv in ditt postort ");
            string postort = Console.ReadLine();


            Console.Write("Skriv in ditt telefon ");
            string telefon = Console.ReadLine();

            Console.Write("Skriv in ditt email ");
            string email = Console.ReadLine();

            string[] uppgifter = { förnamn, efternamn, adress, postort, telefon, email };

            foreach (var item in uppgifter)
            {
                Console.Write(uppgifter);
            }

            /*
            Console.WriteLine("Dina uppgifter är: \n{0}\n{1}\n{2}\n{3}\n{4}\n{5}", förnamn, efternamn, adress, postort, telefon, email);


            */


            //2.Skapa ett program där användaren får upp fyra frågor om att mata in ett tal

            /*
           
            Console.Write("Mata in tal 1 ");
            int tal1 = int.Parse(Console.ReadLine());

            Console.Write("Mata in tal 2 ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.Write("Mata in tal 3 ");
            int tal3 = int.Parse(Console.ReadLine());

            Console.Write("Mata in tal 4 ");
            int tal4 = int.Parse(Console.ReadLine());

            int[] allaTal = { tal1, tal2, tal3, tal4 };



           

            Console.Write("Största talet du skrev in är: {0}", allaTal.Max());

            */


            // 3. Utöka uppgift 2 med en inledande fråga där användaren får ange hur många tal


            /*
            Console.Write("Ange hur många tal vill du skriva in ");
            bool status = int.TryParse(Console.ReadLine(), out int antalTal);
           

            if (status)
            {
                int[] input = new int[antalTal];
            }


            for (int i = 0; i < antalTal; i++)
            {
                
                Console.Write("Mata in tal 1 ");
                int input = int.Parse(Console.ReadLine());

            }

            */


            // 4. Skapa en array av 5 heltal och fyll den med värden. 
            /*
           

            */




            ///////5. Skapa en array som skall innehålla temperaturmätningar. 




























            Console.ReadLine();
            Console.WriteLine("Tryck enter för att avsluta");
            Console.ReadLine();


        }
    }
}

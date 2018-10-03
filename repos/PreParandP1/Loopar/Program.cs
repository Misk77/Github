using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loopar
{
    class Program
    {
        static void Main(string[] args)
        {


            //////////  LOOPAR   \\\\\\\\\\\\\\\\\\\


            //1. skriver ut talen 0-10 på skärmen. Lös detta med en for-loop.
            /*
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

    */

            ///2.mata in två tal. Låt sedan programmet skriva ut alla tal
            // som finns mellan dessa två tal på skärmen

            /*
            Console.WriteLine("Mata in ett heltal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in ett heltal");
            int tal2 = int.Parse(Console.ReadLine());
            

            for (int i = tal1; i < tal2; i++)
            {
                Console.WriteLine(i);
            }
            */

            //3. Skapa ett program där användaren skriver två tal, ge summan och fråga
            // ifall användaren vill avsluta eller upprepa uppgiften

            /*
            while (true)
            {
                Console.WriteLine("Mata in ett heltal");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Mata in ett heltal");
                int tal2 = int.Parse(Console.ReadLine());


                int summa = (tal1 + tal2);

                Console.WriteLine("Summan av dessa tal bllir: " + summa);

                Console.Write("Vill du fortsätta (j/n)? ");
                string input = Console.ReadLine().ToLower();

                Console.WriteLine();

                if (input == "n")
                {
                    Console.WriteLine("*Nu avslutas programmet");
                    break;
                }
            }
            
            */

            /// 4. Be användaren mata in ett tal. Spara värdet i en variabel. Upprepa detta 10 gånger.  
            /// 
            /*
            int summa = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Mata in ett heltal: ");
                summa += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summan av dina tal är: " + summa);
           
            */


            // 5. Skapa ett program där användaren får mata in ett tal. Låt sedan programmet skriva ut alla
            //siffor som är mindre än det inmatade talet men större än 0.Lös detta med en loop.

            /*
             * 
            Console.WriteLine("Mata in ett heltal: ");
            int input = int.Parse(Console.ReadLine());

            for (int i =1; i < input; i++)
            {
                Console.WriteLine(i);
            }


    */

            // Exempel WHILE-LOOP

            /*
           string input = "j";
           while (input == "j")
           {
               Console.WriteLine("Vill du forsätta (j/n)");
               string svar = Console.ReadLine();

               if (svar == "n")
               {
                   break;
               }
           }

   */




            // 6. skriv in ett tal, upprepa ifall svaret ej 10


            /*
            Console.WriteLine("Mata in ett heltal: ");
            int input = int.Parse(Console.ReadLine());

            while (true)
               
            {
                if (input < 10)
                {
                    Console.WriteLine("Talet är lägre än 10");
                    Console.WriteLine("Mata in ett heltal: ");
                    input = int.Parse(Console.ReadLine());
                }
                else if (input > 10)
                {
                    Console.WriteLine("Talet är högre än 10");
                    Console.WriteLine("Mata in ett heltal: ");
                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Talet är rätt 10");
                    break;
                }
            }
           
    */

            // 7. 

            /*

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


            */


            ////  MODULUS: Eget exempel på udda och jämna tal mellan 100


            /*

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Talet {0} är udda", i);
                }
                else
                {
                    Console.WriteLine("Talet {0} är jämnt", i);
                }
            }

    
    */

            // 8.




            Console.ReadLine();
            Console.WriteLine("Tryck enter för att avsluta programmet");
            Console.ReadLine();
        }
    }
}

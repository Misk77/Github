using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Iterationer sk. Loopar


            /* En for loop används för att itera mellan två givna tal
             * Deklarera upp en int variable(oftast som int i = 0;
             * i++ gör att  loopen går framåt
             * loopa ALDRIG utanför index
             * 
             */

            //Exempel 1
            /*
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

    */
            /*
                    * /Alltid Addera 2

                   for (int i = 0; i < 100; i += 2)
                   {
                       Console.WriteLine(i);
                   }

           */


            //Exempel

            /*
           Console.WriteLine("Mata in ett heltal: ");
           int input = int.Parse(Console.ReadLine());


           for (int i = 1; i < input; i++)
           {
               Console.WriteLine(i);
           }

           */

            //Exempel

            /*
        double summa = 0;


        Console.Write("Hur många tal vill du skriva in ");
        int svar = int.Parse(Console.ReadLine());

        for (double i = 0; i < svar;i++ )
        {

            Console.Write("Mata in ett tal");


            summa += summa= double.Parse(Console.ReadLine());

        }

        Console.WriteLine("svaret blir: {0}", summa );

*/



            //Ändra på intervallet
            // Man kan ändra på intervallet ifall man ej vill starta från 0

            /*
            Console.WriteLine("Mata in ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Mata in ett tal");
            int tal2 = int.Parse(Console.ReadLine());




            for (int i = tal1; i <= tal2; i++)
            {
                Console.WriteLine(i);
            }

    */

            // WHILE LOOPEN
            // Används om man vill skapa en loop som ska vara  aktiv under ett givet villkor
            // While = så länge

            //Exempel 

            /*
            int x = 0;

            while (x < 10)
            {
                Console.WriteLine("Villkoret stämmer inte, X är inte 10, x = {0}", x);
                x++;
            }

            Console.WriteLine("Villkoret stämmer,      X är nu {0},   x = {0}", x);

            */


            /*
             * 
            while (true)
            {
                Console.WriteLine("Vill du försöka igen (ja/nej)");
                string svar = Console.ReadLine().ToLower();

                if (svar == "nej")
                {
                    break;
                }
            }

            */


            // While loop forts.
            // Om man vill specifikt testa mot ett värde

            /*
            string input = "ja";


            while (input == "ja")
            {
                Console.WriteLine("Vill du försöka igen (ja/nej)");
                string svar = Console.ReadLine().ToLower();

                if (svar == "nej")
                {
                    break;
                }
            }

    */
            //
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


            // WHILE-LOOP Exempel // Fylla en sträng med data

            /*
            string name = "";

            while (true)
            {
                if (string.IsNullOrWhiteSpace(name)) ;
                {
                    Console.WriteLine("Mata in namn");
                    name = Console.ReadLine();

                }

                if (!string.IsNullOrWhiteSpace(name)) ;
                {
                    Console.WriteLine("Allt ifyllt");
                    break;

                }
            }



            */

            /// For-Each-Loop
            ///  Loopa alla objekt i en lista/array
            ///   För varje i listan skriv ut längden på strängen
            ///   

            //Exempel: eget exempel hur man kan göra lista och skriva ut

            /*
             * List<string> names = new List<string>();
            names.Add("Kalle");
            names.Add("boll");
            names.Add("stuga");
            names.Add("hej");
            names.Add("exempel");
            names.Add("dator");
            names.Add("gåshud");
            names.Add("fotboll");
            names.Add("test");



            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            */


            /*
            List<string> items = new List<string>();
            

            foreach (var item in items)
            {
                Console.WriteLine(item.Length);
            }
            */

            /////////  += operator
            // x += y är samma sak som x = x + y

            /*
            int x = 5;
            x += 6;

            Console.WriteLine(x);
               */


            ///////////// += i en loop
            ///

            /*
            int summa = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mata in ett tal");

                summa += int.Parse(Console.ReadLine());
            }

            */

            ///// EXEMPEL 2- eget ex; mata in hur många tal användaren vill göra

            /*
          
                        int summa = 0;
           

            Console.Write("Hur många tal vill du skriva in ");
            int svar = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in talen du vill addera ");
            Console.WriteLine();
            for (double i = 0; i < svar;i++ )
            {
               
                Console.Write("Mata in ett tal ");
               
                
                summa += summa= int.Parse(Console.ReadLine());
                
            }
            
            Console.WriteLine("svaret blir: {0}", summa );

    */


            //// % Modulus operator
            // Räkna ut resten av divisionen mellan första och andra talet
            // x % y
            // modulus = resten 

            /*
             
           
            Console.WriteLine(5 % 2);// 2*g2 blir 4, resten är 1
            Console.WriteLine(100 % 10); // 10*10 är 100 , ingen rest
            Console.WriteLine(-5 % 2); // minus 1
            Console.WriteLine(5.0 % 2.2);// double
            Console.WriteLine(5.0m % 2.2m); // decimal
            Console.WriteLine(-5.2 % 2.0); // minus double

    
    */









            Console.ReadLine();
            Console.WriteLine("tryck");
            Console.ReadLine();

        }
    }
}

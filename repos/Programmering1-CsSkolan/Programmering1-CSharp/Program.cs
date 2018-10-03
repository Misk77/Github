using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programmering1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////// //////////////Programmering 1 - csharpskolan

            //////////////////////// https://www.youtube.com/watch?v=Zk7oa-RLsQA&t=127s \\\\\\\\\\\\\\\\\\\\\\\\\\\\





            /*////////////////////////// Video 1 - In & utmatning i Console Application \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
             * https://www.youtube.com/watch?v=Zk7oa-RLsQA&t=127s
             * 
             * 
             */

            /// Olika inmatningar
            /*
            Console.WriteLine("Hello World"); // skriver ut på ny rad
            Console.WriteLine("Hello World"); // writeLine
            Console.WriteLine("Michel skoglund ");
            Console.Write("Hello World "); // skriver ut på samma rad
            Console.Write("Hello World ");// write
            Console.Write("Hello World ");//
            Console.Write("Michel Skoglund ");//
            // raden under sista Line kommer byta rad, write forsätter på samma rad
            Console.Write("Hello World " + "Michel skoglund");
            Console.WriteLine("Hello World " + "Michel skoglund");
            Console.WriteLine("Hello World " + "Michel skoglund");

    */
            /*
             *   
                    String inmatat;
                    Console.WriteLine("Mata in ditt namn: ");
                    inmatat = Console.ReadLine();

                    Console.WriteLine("Hej " + inmatat);

            */


            // skriva ut ett tal, en uräkning
            // Använder int.Parse för att ändra inmatat string till int

            /*
            string inmatat;
            int tal;

            Console.WriteLine("Skriv in ett tal: ");
            inmatat = Console.ReadLine();
            tal = int.Parse(inmatat);

            Console.WriteLine("Du matade in talet "+tal);
            Console.WriteLine("Dubbla talet blir:  " + tal * 2);
*/







            /*////////////////////////// Video 2 - Variabler \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            * 
            * Variabler kan hålla vissa binära tal
            * Binära talsystemet
            * Från höger till vänser har binära värdet 0,1,2,4,8,16,23,64, osv
            * 
            * Lägsta är bit 0000= 0 , 0001= 1, 0010 = 2, 0111 = 7
            * 
            * int är 32 bitar: Håller heltal
            * int Max värde     = 2147483647 ( Miljarder)
            * int minsta värdet = -2147483648
            * 
            * Long = 64 bitar 
            * Max =  9223372036854775807
            * Min = -9223372036854775808
            * 
            * unsigned ex: uint, Endast positiva heltal uint, ulong, ushort
            * Så man kan få nästan dubbel så långt positiva heltal. alla 
            * 
            * Double = flyttal är 64 bitar
            *  0.123
            *  
            *  decimal = mera avancerad, tar så mycket byte den behöver, 
            *  decimal bättre räkna pengar, mera exakt
            * 
            */



            /*
     
            int tal = int.MaxValue;

            long tal1 = long.MinValue;


            Console.WriteLine(tal);
            Console.WriteLine(tal1);

            */

            /*
            Console.WriteLine("Mata in ett  heltal: ");
            string inmatat;
            inmatat = Console.ReadLine();
            int mittHelTal = int.Parse(inmatat);

            Console.WriteLine("Mata in ett decimaltal");
            inmatat = Console.ReadLine();
            double mittDecimalTal = double.Parse(inmatat);


            Console.WriteLine("Summan av talen blir: " +(mittHelTal + mittDecimalTal));

            */

            //////////// Räkna ut ett tal - kakylator

            // exempel 1
            /* 
            string  inmatat;

            Console.WriteLine("Mata in ett tal 1: ");
            inmatat = Console.ReadLine();
            int tal1 = int.Parse(inmatat);//  måste göra så string texten kan ändras till heltal
            
            Console.WriteLine("Mata in tal 2: ");
            inmatat = Console.ReadLine();
            int tal2 = int.Parse(inmatat);

            Console.WriteLine("Summan av dina tal är: " + (tal1 * tal2));
           
            */

            /*

              Console.WriteLine("Mata in ett tal 1: ");
              int tal1 = int.Parse(Console.ReadLine());


              Console.WriteLine("Mata in tal 2: ");
              int tal2 = int.Parse(Console.ReadLine());


              int summa = tal1 * tal2;
              int dive = tal1 / tal2;
              int mod = tal1 % tal2;


              Console.WriteLine("Summan av dina tal är: " + (summa));
              Console.WriteLine("Dividerat : " + (dive));
              Console.WriteLine("modulus : " + (mod));
              */

            // Pick digit //with divide and modules
            /*
                        Console.WriteLine("Enter 3 digit");
                        int n = int.Parse(Console.ReadLine());
                        n = n / 10;
                        n = n % 10;


                        Console.WriteLine("The 2:digit is : " + (n));
                        */



            /*////////////////////////// Video 3 - If satsen \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
          *  If satsen
          *  Villkor, true/false , sant eller falskt
          * Första villkoret som stämmer kommer köras
          * 
          * 
          */

            /*
            bool test = true;

            if (test)
            {
                Console.WriteLine("If-satsen stämmer")
            }
            */
            /*
            Console.WriteLine("ange din ålder");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 18)
            {
                Console.WriteLine("Du har inget körkort");
            }

    */
            /*

                    ////////   Switch satsen 
                    Console.Write("ange en färg");
                    string färg = Console.ReadLine().ToLower());

                    switch (färg)
                    {
                        case "röd":

                            Console.Write("Röd är skön");
                            break;
                        case "blå":.Write("Blå är som havet");
                            break;
                        case "gult":.Write("Gult är kult");break;

                        default:Console.Write("Det är en OK färg"); break;
                    }
                    */


            // Intruduktion Klasser
            /**Gruppera ihop data och lättare att hantera data
             * */

            
            Console.Write("Ange ditt namn ");
            string name = Console.ReadLine();
            Console.Write("Ange  din inkomst ");
            int inkomst =int.Parse( Console.ReadLine());
            Console.Write("Ange antal timmar ");
            int timmar = int.Parse(Console.ReadLine());

            Console.WriteLine("Din timlön blev " + (inkomst/timmar)+  " kr/h");






            Console.ReadKey();

}
}
}

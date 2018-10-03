using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Villkor
            ///



            /*   ......... Operander
             * <  Mindre än
             * >  Större än
             * = Lika med
             * == Jämnförelse
             * - Minus
             * + Plus
             * && Och /AND
             * ||  Eller  OR
             * * Multiplicera
             * / Delat med
             *  <= Mindre eller lika med 
             *  >= Större eller Lika med
             *  != Skiljt från ( inte lika med)
             *  ++ Lägger till en
             *  +=  Addera Värdet på sig själv
             *  
             * 
             * 
             */

            // IF/Else - villkor

            /*
            if(barn)
            {
                pris = 50;
            }
            else
            {
                pris = 30
            }

    */

            /////   If/else villkor
            ///
            /*
                        if(mjölkpaket < 10)
                        {
                            Console.WriteLine("Beställ 30 paket");
                        }
                        else if(mjölkpaket är <= 10 && mjölkpaket <= 20)
                        {
                            Console.WriteLine("Beställ 20 paket");
                        }
                        else
                        {
                            Console.WriteLine("Behöver inte beställa någon mjölk");
                        }

                */



            /// Nästlade if/else if
            /// 
            /*
            if(barn)
            {
                if(dotter)
                {
                    pris = 25;
                }
                else
                {
                    pris = 50;
                }
            }
            else
            {
                pris = 100;
            }

    */

            // Datatypen BOOL
            // Kan ha två lägen: sant eller falskt

            /*
            bool primtal;

            if(primtal)
            {
                Console.WriteLine("primtal");
            }
            else
            {
                Console.WriteLine("Ej primtal);
            }

    */

            /// TRY.PARSE()
            /// 
            /*

            Console.WriteLine("Ange din ålder");

            int ålder;
            bool ärTal = int.TryParse(Console.ReadLine(), out ålder);

            if(ärTal)
            {
                if(ålder < 18)
                {
                    Console.WriteLine("Du är inte myndig");
                }
                else if(ålder > 65)
                {
                    Console.WriteLine("Du är pensionär");
                }
                else
                {
                    Console.WriteLine("Du är myndig");
                }
            }

            else
            {
                Console.WriteLine("Du har matat in felaktig ålder eller tecken, Var god ange ålder i siffror");
            }

                */


            ///// SWITCH/CASE
            ///* Man kan göra en SWITCH mot en string
            ///
            /*
            Console.WriteLine("Mata in en kategori,\"vuxen\",\"pensionär\" eller \"student\": ");
            var kategori = Console.ReadLine();

            switch (kategori)
            {
                case "vuxen":
                    Console.WriteLine("Resan kostar 30 kr för vuxen");
                    break;

                default:Console.WriteLine("Felaktig kategori");
                    break;

            }
            */
            
            





            ///// SWITCH/CASE
            ///* Man kan göra en SWITCH mot en INT








            Console.ReadLine();
            Console.WriteLine("Tryck enter för att avsluta programmet");
            Console.ReadLine();

        }
    }
}

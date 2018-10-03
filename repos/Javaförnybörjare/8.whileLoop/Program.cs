using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int x = 1;
            while (x<10)
            {
                Console.WriteLine("Hej");
                x++;
            }

            */


            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine("Hej " +x);
                x++;
            }



            /*
                 // Bool and while loop, skapa en loop som kör och kör och kör....
                 // Bool true och kommer rulla i evighet
                 //infright loop, i all oändlighet

                 bool x = true;
                 while (x)
                 {
                     Console.WriteLine("Bool true och kommer rulla i evighet");
                 }

         */

            Console.ReadLine();
            Console.WriteLine("tryck enter för att avsluta programmet");
            Console.ReadLine();

        }
    }
}

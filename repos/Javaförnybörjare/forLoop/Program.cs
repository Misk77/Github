using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            /// När man vill upprepa något

            // 1. Adderar på 1 hela tiden
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */


            // 2. subtraherar bort  1 hela tiden
            /*
            for (int i = 0; i < 10; i--)
            {
                Console.WriteLine(i);
            }
            */
            // 3. adderar på 2 hela tiden
            /*
            for (int i = 0; i < 10; i+= 2)
            {
                Console.WriteLine(i);
            }
            */

            // 4. skriver ut texten till argumentet är sant, alltså  upp till tal 10, från 0, 11 gånger sammanlagt

            /*
            for (int i = 0; i <=  10; i++)
            {
                Console.WriteLine("Hej på dig " + i);

            }

    */

            Console.ReadLine();
            Console.WriteLine("tryck enter för att avlusta programmet");
            Console.ReadLine();
        }
    }
}

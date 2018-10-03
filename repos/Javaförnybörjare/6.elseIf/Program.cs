using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.elseIf
{
    class Program
    {
        static void Main(string[] args)
        {


            int x = 8;
            int y = 105;

            if (x > y)
            {
                Console.WriteLine("x är mindre än y");
            }
            else if (x == y)
            {
                Console.WriteLine("x är lika med y");
            }
            else
                Console.WriteLine("x är inte större än y");




            Console.ReadLine();
            Console.WriteLine("tryck enter för att avsluta programmet");
            Console.ReadLine();

        }
    }
}

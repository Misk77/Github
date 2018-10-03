using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodExerice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vill du se dina djur? Tryck Enter dör att se  djuren du har");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Detta är dina djur:");
            Console.WriteLine();
            Animal dog = new Animal("Hund","Stina", 12, 7.6f);
            dog.Print();
            Console.WriteLine();
            Animal cat = new Animal("Katt","Missan", 6, 2f);
            cat.Print();
            Console.WriteLine();
            Animal Elk = new Animal("Älg","Erik", 34, 23.4f);
            Elk.Print();
            Console.WriteLine();
            Console.WriteLine("Num of Animals: "+Animal.count);
           

            Console.ReadLine();

        }
    }
}

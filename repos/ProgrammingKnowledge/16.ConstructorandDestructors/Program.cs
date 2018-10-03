using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ConstructorandDestructors
{
    class Program
    {

        public static void Main(string[] args)
        {
            ConstructorTest cT = new ConstructorTest("Hej constructor ", 45);

            Console.WriteLine(cT.name);
            Console.WriteLine(cT.tal);
           
            

            Console.ReadKey();
            

        }
        
    }
}

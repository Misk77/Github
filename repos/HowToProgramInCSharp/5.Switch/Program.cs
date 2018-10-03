using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // Random random = new Random(); ? funkar inte, hur får random??

            
            int num01 = 7;
            int num02 = 6;

            Console.WriteLine("What is: " + num01 + " multipliced to: " + num02);
            int answer = Convert.ToInt32(Console.ReadLine());




            switch (answer )
            {
                case 1:
                Console.WriteLine("Grattis rätt svar");
            break;
            }
            







            Console.ReadLine();
            Console.WriteLine("TRyck enter");
            Console.ReadLine();
                
        }
    }
}

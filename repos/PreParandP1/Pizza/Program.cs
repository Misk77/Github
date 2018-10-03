using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {

            //Logga in
            User LoggaIn = new User();
            LoggaIn.LoggIn();

            Console.WriteLine();
            Console.WriteLine("Välkommen till Pizzerian");
            Console.WriteLine();
            Console.ReadLine();
            
            //Meny
            PizzaMenu menu = new PizzaMenu();
            menu.Menu();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();

            //Kvitto










            Console.WriteLine();
            Console.WriteLine("Tryck på Enter för att avsluta");
            Console.ReadLine();

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEmployeeConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            int menuSelection = -1;

            while (menuSelection!=0)
            {
                Console.WriteLine("What do you wanna do? ");
                Console.WriteLine("Press 0 to exit ");
                Console.WriteLine("Press 1 to create Employee ");
                var valueSelectedAsString = Console.ReadLine();
                if (int.TryParse(valueSelectedAsString, out menuSelection)) ;
                {
                    if (menuSelection==0)
                    {
                        Console.WriteLine("Bye, Bye");
                    }
                    else if (menuSelection == 1)
                    {
                        Console.WriteLine("Create Employee code here" );
                    }
                    else
                    {
                        Console.WriteLine("Not a valid number, please try again");
                    }


                }
            }
            


        }
    }
}

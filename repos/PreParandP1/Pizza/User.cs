using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
     class User
    {
        //Metod
        public void LoggIn()
        {
            Console.WriteLine("Logga in");

            const string användarnamn = "";
            const string lösenord = "";

            Console.Write("Mata in ditt användarnamn: ");
            string inputanvändarnamn = Console.ReadLine();

            Console.Write("Mata in ditt Lösenordet: ");
            string inputLösenord = Console.ReadLine();

            if (inputanvändarnamn == användarnamn && lösenord == inputLösenord)
            {
                Console.WriteLine("Du är inloggad");

            }
            else
            {
                Console.WriteLine("Matat in fellösenord eller fel användarnamn");
            }

        }







        //Constructor
        public User() { }
    }
}

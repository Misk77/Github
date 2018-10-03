using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5OCH6
{
    class Program
    {
        static void Main(string[] args)
        {
            //////       LEKTION 5 OCH 6    \\\\\\\\\\\\\\\\\\\\\\\\

            /*   KLASSER, METODER, EGENSKAPER, INTERFACE
             *   
             *   
             *   
             *   
             *   */

            // KLASS - CLASS

            /* * En klass är som en ritning/modell. Som man kan salma olika typer av variabler, metoder och events
             *  * En klass kan vara public,priovate eller protected
             *  * Static betyder att bara en kopia finns i minnet och att man måste gå via klassen och inte via en 
             *  instansvariabel
             *  *I C# kan man ÄRVA- mellan klasser - INHERITANCE
             *  
             */

            // 1. skapa en mapp som heter Models
            //2. Skapa en KLASS
            //3. Gör klassen public

            //exempel

            /*
            public class Pizza
            {

            }

            */

            /////    Konstruktor

            /*
             * Varje klass har alltid en Konstruktor, Den kan vara tom
             * Man kan anropa metoder
             * Sätta värde på egenskaper
             */

            //Exempel

            /*
                public class Pizza
        {
            public Pizza()
            {

            }
        }


    */

            // Konstruktor forts.
            /*
             * En konstruktor med INPARAMETRAR
             * 
             */

            //exempel

            /*
            public class Pizza
        {
            public Pizza(int id, string name, double price, List<Ingredient> Ingredients)
            {
            }


        }


    */

            // Konstruktor med EGENSKAPER

            //Exempel

            /*
             public class Pizza
        {
            public Pizza(int id, string name, double price, List<Ingredient> ingredients)
            {
                Id = id;
                Name = name;
                Price = price;
                Ingredients = ingredients;
            }
            public int id { get; set;}
            public string name { get; set; }
            public double price { get; set; }
            public List<Ingredient> ingredients { get; set; }

        }

    */


            // Skapa en PIZZA
            /*
             *  New pizza TRiggar konstruktorn, Man måste skicka in ett ID,Namn,Price
             *  och en Lista med ingredienser
             * 
             */

            //exempel

            /*
            Pizza capriciossa = new Pizza(1, "Capriciossa", 75, new List<Ingredient> { Ham, mushroom });

    */


            // EGENSKAPER

            /* En egenskap håller ett värde på en specifik datatyp
             * Kan vara public, private eller protected
             * 
             * GET= För att hämta värdet
             * SET= Tilldela ett värde
             * 
             * 
             * 
             * 
             * */


            /// Egenskap forts

            // Anropa/Tilldela värdet på en egenskap

            //exempel

            /*
             * 
            Pizza capriciossa = new Pizza(1, "Capriciossa", 75, new List<Ingredient> { Ham, mushroom });

            //anropa egenskap
            double price = capriciossa.Price;
            string name = capriciossa.Name;

            //Tilldela egenskap
            capriciossa.Price = 80;
    
    */

            // METODER

            /* ANVÄNDS för att strukturera och återanvända kod
             * Kan vara private, public, protected
             * En METOD kan returnera en datatyp eller inte(void)
             * Kan ha IN- och UT Parametrar
             * 
            */

            //exempel

            /*
            //Har inga ut och in parametrar och returnerar en USER
            User user = CreateUser();

    */

            // METODER forts

            /* Minimera INPARAMETRAR, Används objekt istället
             * 
             * 
             * 
             * */

            //exempel

            /*
             * 
            public user CreatUser(string firstname,string lastname,string adress,string phone,string email)
            {
                User user = _userService.CreateUser(firstname, lastname, adress, phone, email);
                return user;
            }

            public User CreatUser(User user)
            {
                user = userService.CreateUser(user);
                return user;
            }


    */


            ///INTERFACE
            /*
             * Visar alltid vilka metoder/egenskaper som finns i KLASSEN
             * 
             * Börjar alltid med ett I
             * 
             */

            //Exempel

            /*
            public interface IMenuService
        {
            Menu CreateMenu();

            Pizza GetPizza(int id);

        }

    */

            // INTERFACE forts
            /*
             * Klasser ärver/implenterar interface
             * Notera den privata metoden(se bild)
             * 

   */
   /*
            // anropa ett interface
            IMenuService menuService = new MenuService();
            Menu menu = menuService.CreateMenu();

    */


            ///// LINQ
            ///
            /*Kraftfullt och enkelt sätta att få ut sorterat data från listor
             * HÄMTA alla pizzor ( se bild)
             * 
             * 
           */


            // LINQ forts
            /*
             * Hämta ut 1 pizza efter ett specifikt id
             * 




            Console.ReadLine();
Console.WriteLine("Tryck enter för att avsluta");
Console.ReadLine();

}
}
}

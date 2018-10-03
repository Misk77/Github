using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaMenu
    {
          public void Menu()
        {

       
                
            string input = "j";
            while (input == "j")
            {
                Console.Write("Ange Vilken Pizza du vill ha (1 - Capricciosa, 2- Acapulco , 3 - Quattro Stagioni. 4- Kebabpizza 5-): ");
                int Pizza = int.Parse(Console.ReadLine().ToString());
                int antal = 0;
                antal ++;
                
               
                

                switch (Pizza)
                {
                   
                    case 1:
                        Console.WriteLine("Du har valt en Capricciosa ");
                        antal ++;
                        break;
                    case 2:
                        Console.WriteLine("Du har valt en Acapulco ");
                        antal++;
                        break;
                    case 3:
                        Console.WriteLine("Du har valt en Quattro Stagioni");
                        antal++;
                        break;
                    case 4:
                        Console.WriteLine("Du har valt en Kebabpizza");
                        antal++;
                        break;


                    default:
                        Console.WriteLine("Vill du ha den pizzan får du gå till annan pizzeria!");
                        break;
                }

                Console.WriteLine("Vill du forsätta (j/n)");
                string svar = Console.ReadLine();

                if (svar == "n")
                {

                    Console.WriteLine( "Du har: "+antal+ " .st Pizzor i varukorg ");
                    break;
                }
            }



        }
        }





    //Constructor
   



    
}

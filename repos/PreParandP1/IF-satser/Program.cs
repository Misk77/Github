using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_satser
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //.1. Be användaren att mata in ett tal. Kontrollera om talet är större än 10

            Console.WriteLine("Skriv ett tal");
            int user = int.Parse(Console.ReadLine());


            if (user < 10)
            {
                Console.WriteLine("Talet är mindre än 10");
            }
            else
            {
                Console.WriteLine("Talet är större än 10");
            }

    */

            //2. Be användaren att mata in hur många paket mjölk som finns kvar ifall mindre än

            /*

            Console.WriteLine("Hur många paket mjölk finns det kvar");
            int milkLeft = int.Parse(Console.ReadLine());

            if (milkLeft < 10 )
            {
                Console.WriteLine("Beställ 30 paket mjölk");
            }
            else if (milkLeft  < 10  || milkLeft < 20 )
            {
                Console.WriteLine("Beställ 20 Paket mjölk");
            }
            else
            {
               Console.WriteLine ("Du behöver inte beställa någon mjölk");
            }


            */
            // 3. Be användaren mata in temperaturen tagen från en febertermometer. Om tempen är över 

            /*

            Console.WriteLine("Skriv in din temperatur");
            double temp = double.Parse(Console.ReadLine());


            if (temp >= 37.8 && temp <= 39.5 )
            {
                Console.WriteLine("Du har feber");

            }
             if(temp > 39.5 )
            {
                Console.WriteLine("Du bör uppsöka läkare");
            }
            else if (temp < 37.8)

            {
                Console.WriteLine("Du har inte feber");
            }
            */
    

            //. 4.Be användaren mata in sin ålder. Om den är mindre än 18 är användaren ej myndig. 

            /*
             *EXEMPEL 1
            Console.WriteLine("Skriv in din ålder");
            int useAge = int.Parse(Console.ReadLine());
            

            if (useAge < 18)
            {
                Console.WriteLine("Användaren är inte myndig");
            }
            else if (useAge >= 65)
            {
                Console.WriteLine("Användaren är pensionär");
            }
            else if(useAge >= 18)
            {
                Console.WriteLine("Användaren är myndig men inte pensionär");
            }

    
    */

            ////// ExemPEL 2:   

            /*
            Console.WriteLine("Ange din ålder");
            
            int ålder;
            bool ärTal = int.TryParse(Console.ReadLine(), out ålder);

            if (ärTal)
            {
                if (ålder < 18)
                {
                    Console.WriteLine("Du är inte myndig");
                }
                else if (ålder >= 65)
                {
                    Console.WriteLine("Du är pensionär");
                }
                else
                {
                    Console.WriteLine("Du är myndig");
                }
            }

            else
            {
                Console.WriteLine("Du har matat in felaktig ålder eller tecken, Var god ange ålder i siffror");
            }

    */

            // 5. Be användaren ange vilken kategori den tillhör-vuxen, pensionär, student. 

            /*
            Console.WriteLine("Välj en kategori, \"vuxen\", \"pensionär\" eller \"student\": ") ;
            var kategori = Console.ReadLine();

            switch(kategori)
            {


                case "vuxen":

                    Console.WriteLine("resan kostar 30 kr");
                    break;

                case "student":
                case "pensionär":

                    Console.WriteLine("resan kostar 20 kr");
                    break;

               

                default:
                    Console.WriteLine("Felaktigt val");
                    break;
            }
                
    */

            // 6. Be användaren mata in sitt födelse år. Om ....

            /*
            Console.WriteLine("Mata in ditt födelse år");

            var födelseår = int.Parse(Console.ReadLine() );

            if (födelseår)
            {
                if (födelseår >= 1980 || födelseår > 1990)

                {
                    Console.WriteLine("Du är född på 1980-talet");
                }
                else if (födelseår < 2000 || födelseår >= 1990)
                {
                    Console.WriteLine(" Du är född på 1990-talet");

                }
                else if (födelseår < 1980 || födelseår >= 2000)
                {
                    Console.WriteLine(" Du är inte född på 1990 eller 1980-talen");
                }

                else
                    Console.WriteLine("Något i koden är fel");
            }

    */

            //7. Skapa en inloggning där användaren först får ange användarnamn och sedan lösenord

            /*
            const string användarnamn = "Michel";
            const string lösenord = "Hej";

            Console.Write("Mata in ditt användarnamn: ");
            string inputanvändarnamn = Console.ReadLine();

            Console.Write("Mata in ditt Lösenordet: ");
            string inputLösenord = Console.ReadLine();

            if(inputanvändarnamn == användarnamn && lösenord== inputLösenord)
            {
                Console.WriteLine("Du är inloggad");
            }
            else
            {
                Console.WriteLine("Matat in fellösenord eller fel användarnamn");
            }

            */

            // 8. Be användaren att mata in namnet på ett land där den bor. 

            /*
            Console.Write("ange ditt hemland (1 - sverige, 2- finland, 3 - danmark. 4- norge): ");
            int land = int.Parse(Console.ReadLine().ToString());

            switch (land)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Du bor i Skandinavien.");
                    break;


                default:
                    Console.WriteLine("Du  bor inte i Skandinavien");
                    break;
            }

    */

            // //  9. Be användaren mata in ett bilmärke

             /*
            Console.Write("Mata in ett bilmärke (1 - Volvo, 2- Volkswagen, 3 - BMW, 4 Audi, 5-Renault, 6-Peugeot,7- Citroen): ");
            int bilmärke = int.Parse(Console.ReadLine().ToString());

            switch (bilmärke)
            {
                case 1:
                    Console.WriteLine("Grattis du har en svensk bil.");
                    break;

                case 2:  
                case 3:
                case 4:
                    Console.WriteLine("bilen är tysk.");
                    break;

                case 5:
                case 6:
                case 7:
                    Console.WriteLine("bilen är fransk.");
                    break;

                default:
                    Console.WriteLine("bilen inte är tysk eller fransk eller svensk. ");
                    break;
            }

    */
            //10. Be användaren mata in en summa på hur mycket pengar den har.

            /*
            Console.WriteLine("Hur mycket pengar har du");
            double summa = int.Parse(Console.ReadLine());

            Console.WriteLine("Har du rabbat?");



            if (summa > 15 >= 25)
            {
                Console.WriteLine("");
            }
            else if (summa >= 65)
            {
                Console.WriteLine("");

            }
            else if (summa > 18)
            {
                Console.WriteLine("");
            }


            else
                Console.WriteLine("");


    */





            



            Console.WriteLine();
            Console.WriteLine("Tryck enter för att avsluta programmet");
            Console.ReadLine();
        }
    }
}

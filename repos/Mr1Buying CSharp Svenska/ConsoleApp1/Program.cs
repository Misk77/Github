using ConsoleApp1;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr1BuyingLearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        { // Kodblock

            /*               Mr1Buying C# Svenska
             * https://www.youtube.com/watch?v=1SWoG-p-qjI&list=PLDH562Qb745NFrMwlweruEZH4rraEcRJ3&index=2
             * 
             * 
             **/

            ///////////////////////// Video 2 - \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            // console är en class // writeLine är en method
            /*
            Console.WriteLine("Hello Kitty!");
            */



            //  /////////////   3. Lektion \\\\\\\\\\\\\\\\\\\\\\
            // Dom fyra största;

            // Int, heltal Integers - 3, 45, 100 101, ....osv
            // float, decimal, double - flutttal, tal med decimaler, olika presicion
            // float bra precission , double ännu bättre precission, decimal bättre
            // String, strängar - text sträng , med appostroffer "HEj" "Hello World"
            // " " - Gör så det blir en textsträng
            //


            //  /////////////   4. Mr1Buying C# Svenska 4 Variabler  \\\\\\\\\\\\\\\\\\\\\\
            /*
             * Compiler - översätter människospråk till maskinspråk(binärkod)
             * 
             * Går igenom vart koderna/projektet sparas
             * Mappen där projektet sparas/in i mappen/kolla under bin mappen där finns debugg och release mapp
             *  I dessa hamnar exe filer som är ditt program
             * */
            //variabel (Variabler)
            /*tecken / namn - som representerar ett värde
             * 
            */

            ///  5 Mattematiska operatorer 
            /*Restdivision - Modulus % 
            * Intelligence - hittar orden som du kanske vill skriva ut
            * 
            * */


            //// 6 Jämförelse operatorer
            /// boolean = bool = true/false  1 = true/0 = false
            /// Booleniask värdet - 

            /*
            bool test = 5 == 5;
            Console.WriteLine(test);

            */


            ////  7 Villkorssatser
            ////*
            ///En dator bearbetar en sak i taget, 
            ///Läser från vänster till höger, gör en sak  itaget och gör det som strå
            ///
            /// 
            ///TÄNK PÅ!! Att första villkoret som stämmer kommer ske, lägg dom i rätt ordning!!

            /*
            int x = 10;
            int y = 19;

            if (x == y)
            {
                Console.WriteLine("Detta stämmer inte!");
               ----  instruktion här---
                //Gör instruktionen som står här exempelvis
            }
            Console.WriteLine("Detta stämmer, gå vidare");
             ----  instruktion här---

            */


            ////// 8 Else if
            ///

            /*
            int x = 10;
            int y = 19;

            if (x==y)
            {
                Console.WriteLine("if satsen körs");
            }

            else if (x < y)
            {
                Console.WriteLine("Första Else if satsen kör");

            }
            else if(x > y )
            {
                            Console.WriteLine("Andra Else if satsen kör");
            }
            else
            {
                Console.WriteLine("Else körs, inget annat stämmer");
            }

            Console.WriteLine("Nu har vi kört igenom hela villkorssatsen");

            */

            ///////////////////////// Video 9 -if sat -  Logiska operatorer-  \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //   

            /*if sats 
             * 
            */

            /*
            int money = 59;
            int price = 43;
            int stock = 4;

            if (money > price) {
                if (stock > 0)
                {
                    money = money - price;
                    stock = stock - 1;
                    Console.WriteLine("Grattis du nu ägare av tomater");

                }
                else
                {
                    Console.WriteLine("Tyvärr, finns inte i lager!");
                }      
                    }

            */



            ////   Logiiska operatorer-

            /*
                        int money = 59;
                        int price = 43;
                        int stock = 0;

                        if (money < price || stock > 0)
                        {
                            Console.WriteLine("Grattis du är ägare av tomater");
                        }

                */


            ///////////////////////// Video 10 - snabbdelnings operatorer
            /*      -=
             *      +=
             *       %=
             *       /=
             *       *=
             *       
             *       pre och post =  stock++  / ++stock   .. operatoren efter så 
             *       lägger den på nästa gång, är operatoren före så lägger den på direkt.
             * */

            /*
            int stock = 78;
            stock -= 1;
            */

            ///////////////////////// Video 11 -Kommentarer

            ///////////////////////// Video 12 -Kontaktering
            /*   +   Lägg till det som ligger till höger, Överladdad operatör
             *   Lägger ihop olika strängar, tal , kontaktering
             * 
             * 
             * 
             * */





            ///////////////////////// 14 While loop 

            /*

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("hej {0} ",x);
                x++;
            }


               */


            ////  15 For loop
            /*
             * Först sätter man upp en kontroll variabel
             * 
             * i betyder = increment = Ökning
             * 
             * Först läser den in ifall en variabel är deklarerad och intitierad, sedan kollar vilkoret
             * sedan gör instruktionen, sedan kollar ökning, och jämnför med villkoret
             */

            /*
             * 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

    */

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hej");
            }

    */

            /*
             // Du kan välja via input hur många gånger detta ska upprepas


            Console.WriteLine("Hur många gånger vill du göra detta? ");
            int antalgånger = int.Parse(Console.ReadLine());

            for (int i = 0; i < antalgånger; i++)
            {
                Console.WriteLine("Antal gånger du valt göra detta {0}",i);
            }

    */

            /////    16 Foreach-Loop    ///////////////
            /*
             * En loop som kan loopa igenom array/List
             * Inom loopen tilldelar man loopen en tillfällig vaiabel som för varje varv får nytt värde, det värde blir 
             * vad som står i List, post, som börjar med index 0
             * 
             * 
             * 
             * 

    */

            /*
            string[] names = {"Kalle", "Jonas", "Bertil", "Sören"};

            foreach (var name in names)
            {
                
                Console.WriteLine(name); // skriver ut allt i names via name, name tillfällig variabel som får nytt värde varje loop
                Console.WriteLine(name.Length); // skriver ut längden på varje ord
                Console.WriteLine();
                Console.WriteLine(name.ToLower());// gör allt till små bokstäver-LowerCase
                Console.WriteLine();
                Console.WriteLine(name.ToUpper());// gör allt till STORA bokstäver-UpperCase
                
            }

    */



            //////////   17 Break och Continue   

            /* Continue -hoppar bara över det som står som villkor, sedan fortsätter resterande instruktioner
             * 
             * Break; kollar villkoret och när villkoret stämmer hoppar break ut ur hela loopen
             * 
             * 
             */


            /*
             * 
            for (int i = 0; i < 10; i++) //i = 0 , villkoret skriv ut i tills villkoret inte stämmer
            {
                if (i==5) // if- Om i = 5, så hoppa över denna instruktion och fortsätt
                {
                    
                    continue;
                }

                Console.WriteLine(i);
            }

            */


            /*
             * 
            for (int i = 0; i < 10; i++) //i = 0 , villkoret skriv ut i tills villkoret inte stämmer
            {
                if (i == 5) // if- Om i = 5, så hoppa ur loopen
                {

                    break; ;
                }

                Console.WriteLine(i);
            }

    */


            ////     Do While loop   ////

            /* do while loopen kommer alltid utföra en instruktion minst en gång det är DO, gör alltid detta
             * sedan kollar den villkoret där while loopen står och utför så länge villkoret inte är sant
             * 
             * 
             * 
             * 

        */

            /*
            int x = 5;
            do
            {
                Console.WriteLine("Gör alltid detta!");
            } while (x > 50); // villkoret stämmer inte så "DO" gör en gång sedan slutar den
           
    */

            /*
            int x = 5;
            do
            {
                Console.WriteLine("Gör alltid detta!");
            } while (x < 50); // villkoret stämmer så "DO" gör en gång sedan fortsätter loppen while x ÄR mindre än 50 blir sant
            
    */


            /////////  19. Switch  ///////////////


            /*
             
            int x = 70;

            switch (x)
            {
                case 10:
                    Console.WriteLine("X är 10");
                    break;

                case 30:
                    Console.WriteLine("X är 30");
                    break;

                case 60:
                case 70:
                case 80:
                case 90:
                case 100:
                    Console.WriteLine("X är någonstans mellan 60 och 100 ");
                    break;

                case 50:
                    Console.WriteLine("X är 50! ");
                    break;

                default:
                    Console.WriteLine("DEFAULT MSG: Värdet finns inte i något CASE");
                    break;
            }

    */


            // 20 Läsa in ifrån konsolen
            /// char ett enkelt tecken ex;  
            /// char sign = 'A';
            /*
             * 
             * */


            /*
                string name;

                Console.WriteLine("Ange ditt namn: ");
                name = Console.ReadLine();

                Console.WriteLine("Ditt namn är: {0}", name);

        */

            //Upprepa samma fråga med While loopen till if blir sant som då kör break ur loopen


            /*

             string name;
             while (true)
             {

                 Console.WriteLine("Ange ditt namn: ");
                 name = Console.ReadLine();

                 Console.WriteLine("Ditt namn är: {0}", name);

                 Console.WriteLine("Vill du skriv in ett namn till? (j/n)");
                string svar= Console.ReadLine().ToLower();

                 if (svar=="n")
                 {
                     break;
                 }
             }

     */



            //////  21 Övningsuppgift ////////







            /////////////////////   22 Klasser och Objekt   //////////////
            // KLASSER är ritningar som man kan stoppa in METODER i

            /* Göra en enkel klass: Skapa klass döp den Inuti klassen 
             * ex: objektet heter BarbieDo som finns inuti classen BarbieSong med referens variablen Barbie
             * 
             * På så sätt kan man lägga allt som Barbie ska sjunga i SingBarbie och hitta Metoden/Function vad barbie ska sjunga via variabeln 
             * Barbie.SingBarbie eller  Barbie.BarbieSpeaks
             * och det du skrivit inom Metoden är det som utförs via barbie variable
             * 
             * Klassen är objekt
             * 
             * BarbieDo är en KLASS 
             * SingBarbie är Objektet
             * barbie - referens variable till klassen
             * Metoden/Functions: Console.WriteLine("Im a Barbie girl, in a Barbie World");
             * 
             * Objektet sparar i sk. "Hipen" The Hip
             * 
             * */

            /*
           
            BarbieDo Barbie = new BarbieDo();

            Barbie.SingBarbie();


            Barbie.BarbieSpeaks();

    */


            ///// 23 Klass variabler
            // Ritningar= klasser Variabler - fält/Fields
            /*
             * Synlighet och variablar
             * 
             * Private är default , så products variable värdet nås inte automatiskt
             * 
             *  Products Lego = new Products(); // Skapa nytt objekt
             *  
             * */


            /*
             * 
            Products Lego = new Products(); // objekt product, refernens variable Lego
            Products Barbie = new Products();//skapat nytt objekt fast med samma ritning // utan värde

            Lego.name = "WaterWorld"; //Lego.name får värde
            Lego.recAge = "7-11";//Lego.recAge får värde

            Console.WriteLine("Leksaken är {0} och rekommenderas för ålder: {1}", Lego.name, Lego.recAge);//Värden tilldelats
            Console.WriteLine("Leksaken är {0} och rekommenderas för ålder: {1}", Barbie.name, Barbie.recAge);//Inga värden tilldelats


    */

            // Eget exempel
            // Kan också nå min egna BarbieDo objekt som är skapat
            //Kan göra hur många som helst och nå dom via objekt variablen

            /*
            Products Lego = new Products(); // objekt product, refernens variable Lego
            Products Barbie = new Products();//skapat nytt objekt fast med samma ritning // utan värde
            BarbieDo BarbieDo = new BarbieDo(); // skapa/åtkomst till mitt objekt BarbieDo

            Lego.name = "WaterWorld"; //Lego.name får värde
            Lego.recAge = "7-11";//Lego.recAge får värde

            Console.WriteLine("Leksaken är {0} och rekommenderas för ålder: {1}", Lego.name, Lego.recAge);//Värden tilldelats
            Console.WriteLine("Leksaken är {0} och rekommenderas för ålder: {1}", Barbie.name, Barbie.recAge);//Inga värden tilldelats
           

            BarbieDo.SingBarbie();


            BarbieDo.BarbieSpeaks();

    */

            ////   24 Metod

            /*Man kan inte göra ett anrop till private metod el variable,utan måste gå via en public variable
             * Private- Kan bara komma åt via samma class
             * 
             * 
             * 
             * Void tar hand om return och eventuella problem automatisk
             * void returnera inte kanske just den datatypen som är tänkt
             * return returnerar den datatypen som du specifikt anger
             */

            /*
             * 
            Products2 Lego = new Products2();
            Lego.DoIt();
            */

            //// 25 Argument

            // args - arguments
            //Man sätter parametrar/argument

            /*
            Product1 Lego = new Product1();
            Product1 Ken = new Product1();

            Ken.SetName("Ken Doll");
            
            Ken.GetName();


            Lego.SetName("Star Wars");
            Lego.GetName();

    */


            //. 26 Return
            /*Allt efter Return; kommer ej köras, return avslutar kodblocket
             * Kan inte ha VOID, VOID returnerar inget, eller tar hand om det själv
             * 
             * return hänvisar till vilken datatyp som ska returneras
             * Först ange dtatypen till PrintDetails som är text, string
             * 
             * 
             * ex; public string PrintDetails()
             * {
             * string details =("Leksaken ")
             * }
             * return details;
             * 
             * Det som kommer efter retrun måste vara datatypen som du angett
             * 
             * */

            // I klassen product metoden PrintDetals

            //ex;

            //I Main 
            /* 
            BarbieDo Lego = new BarbieDo(); // objekt product, refernens variable Lego
            BarbieDo Barbie = new BarbieDo();//skapat nytt objekt fast med samma ritning // utan värde
            BarbieDo BarbieDo = new BarbieDo(); // skapa/åtkomst till mitt objekt BarbieDo
            string sing = Barbie.SingBarbie(); // return datatyp och hänvisn ing till metoden

                Console.WriteLine(sing);// skriver ut return
                */

            // 27 Main metoden
            /*
             * public - synlighets modifier, så man kan använda denna klass via referenser
             * 
             * void - returnerar inget,tar hand om allting i metodkroppen
             * Main - en Metod som tar in en array strängar
             * args-arguments-  Array variabel 
             * MAIN -start punkten för CLR Common language Runtime, där konsolen börjar
             * public static void Main- söker CLR
             * 
             * Man kan skapa Main metoder i vilken Class man vill, om man nu vill ändra start up object
             * Under menu project< proprties < startup object
      
             * */

            //  28 Egenskaper - 
            // https://www.youtube.com/watch?v=Te4zn2kst8Q&index=28&list=PLDH562Qb745NFrMwlweruEZH4rraEcRJ3

            /*  C# började med Egenskaper
             *  get:set
             * 
             * 
             * 
             * */




            







            Console.ReadKey();


}
}
}
 
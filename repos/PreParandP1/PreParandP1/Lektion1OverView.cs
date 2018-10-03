using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreParandP1
{
    class Lektion1OverView
    {
        static void Main(string[] args)
        {
            //LEKTION 1 - STRÄNGAR

            ////    • I C# (SEE SHARP) FINNS DET OLIKA DATATYPER. ANVÄND STRING TILL
            //  TEXT / NAMN
            //- STRING, INT, DOUBLE, FLOAT, DECIMAL, DATETIME, ARRAY, LIST


            // • DEKLARERA UPP EN STRÄNG
            /*
                        string name = ""; // en tom variable
                        string name = string.Empty; // tom variable
                        string name = null; // tom string
                        string name = "Carl";
                        var name = "";
                        */
            // Man kan skriva "var" som datatyp, var tar alla datatyper men svårare att se, vad det är för data type


            ///////////  KONVENTION

            // • VARIABLER SKRIVS MED camelCase
            // ex:   string förnamn = "carl"
            //       string förOchEfterNamn = "Carl Schéle"

            // • KLASSER, EGENSKAPER OCH METODER SKRIVS MED PascalCase
            //Klasser, Egenskaper, Metoder skrivs med PascalCase

            //klass
            /*
            class Pizzeria
            {
            //egenskap
            string PizzaNamn { get;set }

            //Metod
            private void SkapaPizza();
            }


            ////////  KOMMANDOTOLKEN

            //• ALLTING VI SKRIVER/LÄSER ÄR STRÄNGAR

            // • SKRIVA UT PÅ SKÄRMEN
            // Console.WriteLine("Detta skrivs ut på skärrmen");// writeLine byter rad nästa utskrivt, write stannar på samma rad

            //• LÄSA FRÅN SKÄRMEN
            //   Console.WriteLine(); // väntar på input från skärmen/användaren
            //   string name = Console.ReadLine();// lagrar inputen i variabeln "name"

            */

            /////////// KOMMANDOTOLKEN
            // • VAD ÄR DET FÖR SKILLNAD PÅ
            //Console.WriteLine() och Console.Write()
            // Console.WriteLine("Detta skrivs ut på skärrmen");// writeLine byter rad nästa utskrivt, write stannar på samma rad
            //   Console.WriteLine(); // väntar på input från skärmen/användaren


            //• FÖRHINDRA PROGRAMMET ATT STÄNGA NER AUTOMATISKT
            //Console.ReadLine(); // så skärmen väntar på input



            ///////  VÅRT FÖRSTA PROGRAM
            /*
                        Console.WriteLine("Ange ditt namn: ");//skriver ut texten på skärmen
                        string namn = Console.ReadLine();/AttributeTargets in input från användaren som sparas i variabel namn
                        Console.WriteLine("Du heter " + namn);/skrivet ut text och skriver ut variable namn värde 

                        Console.WriteLine();// gör en tom rad på skärmen

                        Console.WriteLine("Du heter {0}", namn); skriver ut texten och värdet i varible


            ////  STRÄNGHANTERING

            Console.Write("Ange ditt förnamn ");
            string förnamn = Console.ReadLine();
            Console.Write("Ane ditt efternamn  ");
            string efternamn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Du heter "+förnamn +" "+ efternamn);
            Console.WriteLine();
            Console.WriteLine("Du heter {0} {1}", förnamn,efternamn);

            */

            // DATATYPEN INT

            // • STRÄNG OCH TAL SOM SPARAS SOM EN string
            /*
            string name = "Michel";//variabel med namnet
            int age = 41;//variabel med heltal
            Console.WriteLine();
            Console.WriteLine("Jag heter {0} Och är {1}",name, age);//skriver ut texten och varibel
            Console.WriteLine();
            Console.WriteLine("Jag heter " + name + " och är " + age);

            Console.WriteLine();
            Console.WriteLine("Tryck enter för att avsluta programmet");
            Console.ReadLine();


                

            //// BERÄKNINGAR

            // • HELTAL MELLAN -2147483648 OCH 2147483647
            Console.WriteLine("Int");
            Console.WriteLine (Int32.MaxValue);
           Console.WriteLine(Int32.MinValue);
           Console.WriteLine();
            Console.WriteLine("Decimal");
           Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine();
            Console.WriteLine("double");
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            
           

            // INT OCH DOUBLE

            Console.WriteLine("Skriv in tal 1");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in tal 2");
            int tal2 = int.Parse(Console.ReadLine());

            double summa = (tal1 + tal2) * 1.25;

            Console.WriteLine("Summan blir: " + summa);



    

            // DATUM
            // • HANTERA DATUM MED DATATYPEN DateTime
            
            DateTime dagensdatum = DateTime.Now;//dagens datum
            int nuvarandeår = DateTime.Now.Year;//året nu
            DateTime datum = new DateTime(2018, 02, 21);// hårdkodad datum
            DateTime datumMedTid = new DateTime(2018, 02, 21, 19, 0, 0);// hårdkodad år,datum, tid

            Console.WriteLine(dagensdatum);
            Console.WriteLine(nuvarandeår);
            Console.WriteLine(datum);
            Console.WriteLine(datumMedTid);

            


    */







            Console.WriteLine();
Console.WriteLine("Tryck enter för att avsluta programmet");
Console.ReadLine();

}
}
}

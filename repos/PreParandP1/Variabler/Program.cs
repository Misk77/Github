using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////// Variable\\\\\\\\\\\\\\
            /*
             //.2
            string name = "Michel";

            Console.WriteLine("Hello " + name);

    //////////////////////////
    //.3

            string name = "Michel ";
            int age = 41;

            Console.WriteLine(name + age);

            /////////////////////////////////
            
          
            //.4 
           

            Console.Write("Hello World ");// Write byter inte rad för nästa utskrivt
            Console.Write("Hello World ");

            Console.WriteLine("Hello World ");//Line Byter rad för nästa utskrivt
            Console.WriteLine("Hello World ");
            Console.WriteLine("Hello World ");
            */

            /*
            //.5 Skapa en Console-applikation där användaren matar in för och efternamn. 

            Console.Write("Skriv ditt förnamn: ");
            string förnamn = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn: ");
            string efternamn = Console.ReadLine();



            //Console.WriteLine("Du heter: " + efternamn + ","+ förnamn) ;
            Console.WriteLine("Du heter {0},{1}: " , efternamn,förnamn) ;

            */



            //.6 6. Skapa en Console-applikation där användaren matar in två tal 

            /*
            Console.WriteLine("Skriv in ett tal 1");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal 2");
            int tal2= int.Parse(Console.ReadLine());

            double summa = tal1 + tal2;

            Console.WriteLine("Summan av talen är " + summa);

            */

            //.7. Skriv ett program som tar in ett födelse år från användaren. 

            /*

            Console.WriteLine("Skriv in ditt födelseår");
            int YearOfBirth = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - YearOfBirth;

            Console.WriteLine("Din ålder är: " + age);
            Console.WriteLine("Din ålder är {0}: " , age);
            //

            // ??c. Pröva att sätta dagens datum i en variabel och utgå från årtalet i detta datum i din
            //räkning.

            */

            //.9. Mata in två tal och returnera medelvärde, summa och differens mellan dessa tal 

            /*

            Console.WriteLine("Skriv in ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal");
            int tal2 = int.Parse(Console.ReadLine());

            double summa = tal1 + tal2;
            double mV = summa / 2;//medelVärdet
            double dF = tal2 - tal2;//diFferensen

            Console.WriteLine("Summan av dessa två tal är: " + summa +'\n'+ "Medelvärdet av dessa två tal är: " +mV+'\n'+ "Differensen av dessa två tal är: "+ +dF);

            */

            //.10. Be användaren mata in en summa. Lägg på 25% moms dvs summan gånger 0,25 och skriv på 

            /*
            Console.Write("Skriv in summan ");
            double summa = double.Parse(Console.ReadLine());

            double mM = summa * 1.25;

            Console.WriteLine("Summan ink Moms blir: " + mM);


            */

            //Lite svårare uppgifter


            /*11.Skapa ett program där användaren matar in ett antal minuter
             
             * (minst 60 minuter).Programmet
            omvandlar sedan detta till timmar och minuter.

            */
             
            /*

            Console.WriteLine("Skriv in antal minuter, minst 60 minuter");
            double time = double.Parse(Console.ReadLine());

            double timeInHour = time / 60;
            double timeInMin = time;
            double timeInSec = time *  60;
            

            Console.WriteLine("Your time in hours are: " + timeInHour +'\n'+"Your time in minutes are: "+timeInMin+ '\n'+ "Your time in Seconds are: " +timeInSec);
            */

    






            Console.WriteLine ();
 Console.WriteLine("Tryck enter för att avsluta programmet");
 Console.ReadLine();

}
}
}

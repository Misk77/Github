using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodarApanLearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////////      Video 1 - 1000    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            // https://www.youtube.com/watch?v=avYe_Ag7Ps8 
            /* 
             * 
                        double hourPerDay;
                        DateTime finishedDate = DateTime.Today;
                        TimeSpan timeSpan;

                        Console.WriteLine("How many hours per day you want pratice");
                        String answer = Console.ReadLine();

                        while (!double.TryParse(answer, out hourPerDay) && hourPerDay <= 0.0)
                        {
                            Console.WriteLine("Invalid input, please try again");
                            answer = Console.ReadLine();
                        }
                        finishedDate = finishedDate.AddDays(1000 / hourPerDay);
                        timeSpan = finishedDate - DateTime.Today;
                        int years = timeSpan.Days / 365;

                        Console.Clear();
                        Console.WriteLine("Practicing {0} hours per day if starting today you would be finished in\n{1}",
                            hourPerDay, finishedDate.ToShortDateString());

                        Console.WriteLine("You would be going for\n{0} years and {1} days.", years, (finishedDate.AddYears(-years) - DateTime.Today).Days);
                        Console.ReadKey();

                */


            ///////////////// Video 2 - Variables ( const(constanter) variable = cant change it original value.\\\\\\\\\\\\\\\\\\\\\\\\\\

            /*
            String name = "Michel";
            int age = 41;
            short money;
            bool enJoyProgramming;
            char programmingGrade;

            double walkngSpeed = 100.485;
            float runningSpeed = 10.0f;


            money = 100;
            enJoyProgramming = true;
            programmingGrade = 'A';

    */

            //exempel 2
            /*
                        String originalName = "Michel";
                        String newname;
                        int age;

                        Console.WriteLine("Wich name do you wanna have?");
                        newname = Console.ReadLine();

                        Console.WriteLine("How old are you");
                        age = int.Parse(Console.ReadLine());


                        Console.WriteLine("Your original name was {0} and your new name is {1} and you age is {2}", originalName,newname,age);

                        Console.ReadKey();

                */

            ////////////////////////////* Video 3 - if- satser \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            /*  * ==  Betyder att värdet är samma
              * != Betyder att värdet inte är samma
              * >  Är det sant att värdet till Vänster är högre än värdet till höger
              * < Är det sant att värdet till höger är högre än värdet till vänster
              * >= Är det sant att värdet till vänster är högre eller likamed värdet till höger
              * <= Är det sant att värdet till höger är högre el likamed värdet till vänster
              *  && OCH / AND
              *  || Or / ELLER
              * */

            /*

           int age = 20;


            if (age == 15)
            {
                Console.WriteLine("Its true, the age is 15");
            }
            else if (age < 15)
            {
                Console.WriteLine("Värdet är mindre än 15");

            }
            else if (age > 15)
            {
                Console.WriteLine("Värdet är högre än 15");
            }
            else
            {
                Console.WriteLine("Its not true!");

            }


            Console.ReadKey();
            

    */



            /////////////////////// Video 4 -  Aritmetik \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            /* c# har sju olika aritmetik värden
             * + , -,  * , /,
             * Decimaltal använd f, float = 1.9f
             * Paranteser räknas ut först
             * Kan använda variable
             * 
             * 
             * 

    */


            // ex 1
            /*
            Console.WriteLine(5 + 7);
            Console.ReadKey();

    */
            // ex 2 , celcius to convert to farhenehit
            /*
                        Console.WriteLine("Please enter a degree in celcius to convert to farhenehit");
                        float celcius = float.Parse(Console.ReadLine());

                        float farhenehit = ((9f / 5f) * celcius) + 32;
                        Console.WriteLine("{0} celcius is {1} degrees farhenehit", celcius, farhenehit);

                        Console.ReadKey();


                */


            //////////////////////////// Video 5 - arrays \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            /*samling av data, element, icke dynamisk
             * [] makes an array: 
             * int[] string[]
             * 
             * 
             * 
             * */
            /* Emepel 1
                        int[] numbers= new int[5]; 
                        
                        numbers[0] =  5;
                        numbers[1] = 10;
                        numbers[2] = 20;
                        numbers[3] = 35;
                        numbers[4] = 40;

                        Console.WriteLine(numbers[4]);
                        Console.ReadKey();

            // OR: give value like this:   int[] numbers = new int[5] {5,10,20,30,40};

                */
            /*
                        // exempel 2 array with strings
                        int[] numbers = new int[5] { 5, 10, 20, 30, 40 };
                        String[] countries = new string[] { "japan", "india", "sweden", "norway", "Kenya" };
                        //Console.WriteLine(countries[3]); // countries arrays value in array 3
                        // Console.WriteLine(countries.Length);  // how many arrays in countries array
                        // Console.WriteLine(numbers.Max()); // Highest value in the arrays
                       // Console.WriteLine(numbers.Min());  // Lowest value

                        Console.ReadKey();

                */

            // Sort arrays
            /*
            int[] numbers = new int[5] { 5, 10, 20, 30, 40 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            


            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            */

            ///// Two-Dimensional Arrays, multi-dimensional array 
            /*
                        int[,] value = new int[,] { { 1, 7 },{ 23, 28 } };
                        Console.WriteLine(value[0, 0]);
                        Console.WriteLine(value[1, 1]);
                        */


            //////////////// Video 6 - for-loop \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            /*Iteration , uppreppning inom matematik, loop upprepar
             * 
             * 
             * 
             * 
             * 
             */
            /*
             *           for loop som repeterar till argumentet stämmer
             *            
                        int[] numbers = new int[5];

                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(i);
                        }

                */
            // Hårdkoda helst inte utan dator kan kolla efter arrayens längd

            /*   int[] numbers = new int[5];  // arrayen är 5 st, hårdkodad, välj att datorn kan kolla själv 
               //hur lång array är ifall du ändras antal arrayen i koden senare

               Random dice = new Random();


               for (int i = 0; i < numbers.Length; i++)
               {
                   numbers[i] = dice.Next(11);
               }

               for (int i = 0; i < numbers.Length; i++) 
               {
                   Console.WriteLine(numbers[i]);
               }
               */

            // Exempel Linear search




            Console.ReadKey();
        }
    }
}

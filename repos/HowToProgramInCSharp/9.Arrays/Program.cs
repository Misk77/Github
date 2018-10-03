using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            int[] numbers = new int[5];
            numbers[0] = 02;
            numbers[1] = 12;
            numbers[2] = 22;
            numbers[3] = 32;
            numbers[4] = 42;
           

            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers.Length);
            

    */


            // Print out all number via FOR LOOP

            /*
            int[] numbers = new int[5];
            numbers[0] = 02;
            numbers[1] = 12;
            numbers[2] = 22;
            numbers[3] = 32;
            numbers[4] = 42;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

    */

            // Print out all numbers with foreach LOOP

            /*
            int[] numbers = new int[5];
            numbers[0] = 02;
            numbers[1] = 12;
            numbers[2] = 22;
            numbers[3] = 32;
            numbers[4] = 42;

            foreach (var item in numbers) // item är en tillfällig varibael som får nytt värde eftersom loopen går, tar nytt värde index via arrayen
            {// item kan du bestämma själv vad den tillfä'lliga variabeln ska ha för namn
                // För varje item i numbers arrayen gör detta
                Console.WriteLine(item);//skriver ut tillfällig variable som får nytt värde via loopen
                
            }

    */

            /// String ARRAY
            /// 

            /*

            string[] names = { "kalle", "Göran", "Bosse", };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

    */


            ///  LIST
            /// 
            /* When you dont know how many you gonna use
             * Array much faster, if you can use array could be performance betterwise
             * 
             * 
             * 
             * */

            /*
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            Console.WriteLine(numbers[2]);// Skriver ut index 1
            */

            //List med for LOOP

            /*
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            // LIST med FOREACH LOOP

            /*
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

    */

            // LIST  . REMOVE from index

            /*
            List<int> numbers = new List<int>();
            numbers.Add(01);// index 0 [0]
            numbers.Add(20);// index 1 [1]
            numbers.Add(30);// index 2 [2]
            numbers.Add(40);// index 3 [3]

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            numbers.RemoveAt(2);//REMOVE index 2, its the numbers.Add(30);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            */


            // ARRAYS MULTIDIMENSIONALL ARRAY
            /*
             * 
             * */

            /*
            //Main windows

            
            Creategrid();




            Console.ReadLine();

        }


        //Method -  CreatGrid
        public static void Creategrid()
        {
            int width = 5;
            int height = 5;

            int[,] grid = new int[width,height];
            grid[2, 3] = 3;

            for (int x= 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write (grid [x, y] + " ") ;
                }
                Console.WriteLine();
            }


    */







        }

    }
}

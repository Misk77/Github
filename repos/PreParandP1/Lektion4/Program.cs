using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Lektion 4- List/Array



            /* 
             * Indexet i en Array börjar alltid på 0, noll
             * Ma kan bara skriva ett värde i ett index
             * 
             */

            //    int[] array = new int[] { 10, 20, 30, 40, 50, };


            ///////////////////////////////////////////////////////////

            /* ARRAY
             * En datatyp för att sortera objekt
             * Finns metoder för att modifiera innehållet
       */

            // En tom aray med två index
            /*
            string[] minArray = new string[2];
            */

            // En array med två strängar
            /*
            string frukter = { "äpplen", "päron" };
            */

            // En array som kan hålla fyra stycken student-objekt
            /*
            string[] array = new student[4];
            */

            ////////////////////////////////////////////////

            // Loopa över en Array

            /*
            string[] frukter = { "äpplen", "päron" };

            for (int i = 0; i < frukter.Length; i++)
            {
                Console.WriteLine(frukter[i]);
            }

    */



            // Loopa över en Array forts.

            /*
            int[] siffror = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            foreach (var siffra in siffror)
            {
                Console.WriteLine(siffra);
            }
            */


            ///////////////////////////////////////////////////

            // Fylla en Array med data

            /*
            Console.WriteLine("Ange ditt förnamn");
            string förnamn = Console.ReadLine();
            Console.WriteLine("Ange ditt efternamn");
            string efternamn = Console.ReadLine();

            string[] personuppgifter = { förnamn, efternamn };

    

            Console.WriteLine("Dina personuppgifter: "   + förnamn + "," + efternamn);
            Console.WriteLine("Dina personuppgifter: {0},{1}" , förnamn, efternamn);

            */

            /////////////////////////////////


            // Fylla en Array via en for-loop

            /*
             * 
            int tal = 10;
            int[] minaTal = new int[tal];

            for (int i = 0; i < tal; i++)
            {
                minaTal[i] = i;
            }

    */

            //////////////Skapa upp en Array med ett givet tal

            /*
             * 
            Console.WriteLine("Ange antal tal: ");

            bool status = int.TryParse(Console.ReadLine(),out int antal);

            if (status)
            {
                int[] = new int[antal];
            }

    */

            ////////////         Min(), Max(), Average() 

            /*

            Console.WriteLine("Hur många mätningar ska göras: ");
            bool status = int.TryParse(Console.ReadLine(), out int mätningar);

            if (status)
            {
                double[] mätningar = new double[antalMätningar];

                Console.WriteLine("Min: {0}", mätningar.Min());
                Console.WriteLine("Max: {0}", mätningar.Max());
                Console.WriteLine("Medelvärdet: {0}", mätningar.Average());
            }

    */


            // /// Reverse

            /*
            string[] frukter = { "äpplen", "päron" };


            // observera returtypen
            IEnumerable<string> reverseArray = frukter.Reverse();

            foreach (var frukt in reverseArray)
            {
                Console.WriteLine(frukt);
            }


    */

            /// TVÅDimensionell ARRAY
            /// 
            /// Spara flera värden kopplad till  varandra
            /// 

            // string[,] array = new string[3, 2]; // 3 är rad 3 2 är Kolumn 2

            // ROW  3 och Column 2



            //Column 0 /Column 1 /Column 2 /Column 3  
            /*    ROW 0 [0][0]     [0][1]      [0][2]      [0][3]
             *    ROW 1 [1]0[]     [1][1]      [1][2]      [1][3]
             *    ROW 2 [2][0]     [2][1]      [2][2]      [2][3]
             *    ROW 3 [3][0]     [3][1]      [3][2]      [3][3]
             *                                THIS one
             * */

            /// TVÅDimensionell ARRAY- Addera värden
            /// 

            /*
            Console.Write("Hur många mätningar ska göras: ");
                bool status = int.TryParse(Console.ReadLine(), out int antalmätningar);

            if (status)
            {
                string[,] mätvärden = new string[antalmätningar, 2];

                for (int i = 0; i < antalmätningar; i++)
                {
                    Console.WriteLine("Mata in ett värde: ");
                    string mätvärde = Console.ReadLine();

                    Console.WriteLine("Mata in ett datum: ");
                    string datum = Console.ReadLine();

                    mätvärden[i, 0] = mätvärde;
                    mätvärden[i, 1] = datum;

                }
            }

    */

            /// TVÅDimensionell ARRAY- Loopa ut värden
            /// 

            /*
             * 
            for (int i = 0; i < antalmätningar; i++)
            {
                Console.WriteLine("mätvärde: {0}", mätvärde[i,0]);
                Console.WriteLine("datum: {0}", datum[i, 1]);

            }

    */

            /// List<DATATYP>();
            /*
             * List är en nyare  DATATYP än ARRAY
             * flera metoder, enklare att jobba med
             * Långsammare
             * 
             */

            /*
            List<mätningar> mätningar = new List<mätning>();
            */


            // En enklare KLASS , Class
            /*
                        public class Mätning
                    {
                        public double Värde = { get; set; }
                        public double Datum = { get; set; }

                    }

                */

            // Lista med mätning

            /*
            List<Mätning> mätningar = new List<Mätning>();

            var mätningsModell = new Mätning
            {
                värde = 37.9;
            datum = 2018 - 04 - 16;
        };

        mätningar.Add(mätningsModell);

            foreach (var Mätning in mätningar)
	{

            Console.WriteLine("mätning.Datum);
            Console.WriteLine("mätning.Värde);
	}

    */


            // Hitta det längsta ordet

            /*
            string[] ord = new string[5];
            string längstaordet = "";


            for (int i = 0; i < ord.Length; i++)
            {
                Console.WriteLine("Mata in ett ord: ");
                ord[i] = Console.ReadLine();

                if (ord[i] != null)
                {
                    if (längstaordet.Length < ord[i].Length)
                    {
                        längstaordet = ord[i];
                    }
                }
            }

            Console.WriteLine("Längsta ordet är: {0} ", längstaordet);

    */







            Console.WriteLine();

            Console.WriteLine("Tryck enter för att avsluta programmet");

            Console.ReadLine();


}
}
}

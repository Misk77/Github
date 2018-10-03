using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BarbieDo
    {
        //public void SingBarbie()
        public string SingBarbie()// Ange datatype så return vet vilken datatyp den ska returnera
        {
            string sing = ("Im a Barbie girl, in a Barbie World");// ge metoden en variable
            return sing;//return använder variablen för returnera

        }


        public void BarbieSpeaks()
        {
            Console.WriteLine("Nu pratar barbie  ");
        }



    }
}

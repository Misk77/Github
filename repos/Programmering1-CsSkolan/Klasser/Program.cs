using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            InkomstInfo info = new InkomstInfo();

            Console.Write("Ange ditt namn ");
            info.name  = Console.ReadLine();
            Console.Write("Ange  din inkomst ");
            info.inkomst  = int.Parse(Console.ReadLine());
            Console.Write("Ange antal timmar ");
            info.timmar  = int.Parse(Console.ReadLine());

            Console.WriteLine("Din timlön blev " + info.Timlön + " kr/h");
        }
    }
}

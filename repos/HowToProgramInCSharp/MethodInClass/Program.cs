using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Addnumber addnumber = new Addnumber();

            Addnumber.Add(8, 3); // This calls the Method and give the method argument
            Addnumber.Add(8, 3, 4);// 3 argument calls Addnumber
            

            Console.WriteLine(addnumber);

            Console.ReadKey();

        }
    }
}

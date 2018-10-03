using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInClass
{
    class Addnumber
    {

        //Methods
        public static void Add(int num01, int num02)//What the Method namne and prameters, what in gonna work with Integers
        {
            Console.WriteLine("Talen adderat blir: \n"+(num01+num02));// 2 int parametersThen you call this method this is what cames out
        }

        public static void Add(int num01, int num02, int num03)// 
        {
            Console.WriteLine(num01 + num02 + num03);// 3 int parametersThen you call this method this is what cames out
        }


        //constructor
        public Addnumber()
        {

        }


           
    }
}

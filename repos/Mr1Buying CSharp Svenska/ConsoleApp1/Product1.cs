using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product1
    {
        //Class variablar
        private string name;
        private int age;
        


        public void SetName(string Pname, int Page)
        {
            name = Pname;
            age = Page;

        }

        public void GetName()
        {
            Console.WriteLine(name);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ConstructorandDestructors
{
    public class ConstructorTest
    {
        public string name;
        public int tal;
      public ConstructorTest(string _name, int _tal)//
        {
            this.name = _name;
            this.tal = _tal;



            Console.WriteLine("The Constructor is Initilized");
        }


        ~ConstructorTest()
        {
            Console.WriteLine("The Distructor is called");  
        }

    

    }
}

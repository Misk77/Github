using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
     class Animal
    {
        //class varibler
        public static int count = 0;

        public string name;
        public int age;
        public float happiness;
        

        //Method
        public void Print()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }


        //Class constructor

            public Animal()// Hård kodad constructor
        {
            name = "spotty";
            age = 6;
            happiness = 0.5f;
            count++;
        }
        

        // constructor med parameter, ändrar värdet i Main
       public Animal(string _name, int _age, float _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;
            count++;
        }
        
    
    }


}

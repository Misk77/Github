using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodExerice
{
    class Animal
    {
        //Class variabler
        public static int count = 0;
        public string name;
        public int age;
        public float happiness;
        public string art;

        //Method
        public void Print()
        {
            

            Console.WriteLine();
            Console.WriteLine("Art: " + art);
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }




        //Constructor
        public Animal(string _art,string _name, int _age, float _happiness)
        {
            art = _art;
            name = _name;
            age = _age;
            happiness = _happiness;
            count++;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Classes
{
    class Animal// Class Animals
    {
        // Class variables

        public static int count = 0;

        public string name;
        public int age;
        public float happines;

        //Class constructor
        public Animal() // Must always have a constructor, (could be empty)
        {
            name = "Spotty";
            age = 6;
            happines = 0.5f;
            count++;
        }
        public Animal(string _name, int _age, float _happines)
        {
            name = _name;
            age = _age;
            happines = _happines;
            count++;

        }

        //Class Method
        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happenies: " + happines);
        }

    }






    class MainClass // Main window There you calls on class and Method
    {

        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Mr Beans: ", 10, 0.8f);
            cat.Print();
            Console.WriteLine();
            Console.WriteLine("Num of Animals: " + Animal.count);

            Console.ReadKey();
        }
    }
}

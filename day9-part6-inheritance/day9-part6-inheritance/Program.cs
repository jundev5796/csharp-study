using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part6_inheritance
{
    // upcasting
    // convert child -> parent
    // convert without data loss

    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Makes animal sound.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog(); // child
            Animal myAnimal = myDog; // upscaling (child -> parent)

            myAnimal.Speak(); // valid code
        }
    }
};

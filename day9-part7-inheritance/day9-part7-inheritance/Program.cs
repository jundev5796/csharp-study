using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part7_inheritance
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("make sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("woof!");
        }
        public void WagTail()
        {
            Console.WriteLine("wag tail.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog(); // upcasting
            myAnimal.Speak(); // woof! (override success)

            Dog d = (Dog)myAnimal;
            d.WagTail();

            Animal myAnimal2 = new Animal();
            myAnimal2.Speak();
        }
    }
}

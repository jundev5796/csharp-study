using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part6
{
    // 1. abstract class
    // An abstract class is a class that cannot be instantiated and can only be used through inheritance.
    // It is used to define common functionality and enforce implementation in derived classes.
    // Abstract methods are declared but not implemented in the abstract class.
    // Any class that inherits from an abstract class must implement the abstract methods.
    abstract class Animal
    {
        // abstract method (No implementation, must be implemented by the derived class)
        public abstract void MakeSound();

        // regular method
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    // inheriting an Abstract Class to create a concrete class with implementation
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.MakeSound();
            myDog.Sleep();

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();
        }
    }
}

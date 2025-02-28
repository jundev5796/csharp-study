using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace day7_part2
{
    // 2. Class
    class Person
    {
        public string Name;
        public int Age;

        // constructor
        // - A special method that is automatically executed when a class is instantiated as an object.
        // - It has the same name as the class and does not have a return type(not even void).
        // - It is often used to set initial values when creating an object.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("constructor w/ parameter activates");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Tom", 25); // create instance
            p1.ShowInfo();

            Person p2 = new Person("Lisa", 30);
            p2.ShowInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part3
{
    class Program
    {
        class Person
        {
            public string Name;
            public int Age;

            public Person() // constructor
            {
                Name = "Unknown";
                Age = 0;
            }

            public Person(string name)
            {
                Name = name;
                Age = 0;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            Person p = new Person(); // instance
            Person p1 = new Person("Bob");// instance with 1 parameter
            Person p2 = new Person("카타리나", 20); // instance with 2 parameter

            Console.WriteLine(p.Name + "," + p.Age);
            Console.WriteLine(p1.Name + "," + p1.Age);
            Console.WriteLine(p2.Name + "," + p2.Age);
        }
    }
}

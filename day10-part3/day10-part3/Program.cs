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

            public Person() // constructor
            {
                Name = "Unknown";
            }
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part7
{
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("Parent Constructor: " + message); // 2
        }
    }

    class Child : Parent
    {
        public Child():base("Success!") // call parent constructor // 1
        {
            Console.WriteLine("called child constructor"); // 3
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
        }
    }
}

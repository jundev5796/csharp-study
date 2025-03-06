using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part8
{
    class Parent
    {
        protected string name;

        // initialize name
        public Parent(string name) // 3
        {
            this.name = name;
            Console.WriteLine($"parent constructor: {name}");
        }
    }

    class Child : Parent
    {
        private int age;

        // call parent constructor: send 'name' and initialize 'age'
        public Child(string name, int age) : base(name) // 1
        {
            this.age = age;
            Console.WriteLine($"child constructor: age = {age}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"name: {name}, age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child("John", 25); // 0
            child.ShowInfo();
        }
    }
}

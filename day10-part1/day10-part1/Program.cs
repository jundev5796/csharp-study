using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNamespace; // create shortcut

// new namespace
namespace YourNamespace
{
    class MyClass
    {
        public void Greet() => Console.WriteLine("Greetings!");
    }
}


namespace day10_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. connecting another namespace
            MyClass myClass = new MyClass();
            myClass.Greet();
        }
    }
}

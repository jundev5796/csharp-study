using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace (avoid clash between other variables and functions)
namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("Hi!");
        }
    }
}

namespace day6_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            dev1.MyClass.SayHello();
        }
    }
}

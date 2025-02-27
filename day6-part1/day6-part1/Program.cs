using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_part1
{
    class Program
    {
        // 1. Function (no parameter, no return value)
        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        // 2. Function w/ parameter
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            PrintHello(); // output
            PrintMessage("Hi");
        }
    }
}

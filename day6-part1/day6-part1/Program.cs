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

        // 3. Function w/ return value
        static int GetNumber()
        {
            return 42;
        }

        static void Main(string[] args)
        {
            // 1.
            PrintHello(); // output

            // 2.
            PrintMessage("Hi");

            // 3.
            int num = GetNumber();
            Console.WriteLine(num);
        }
    }
}

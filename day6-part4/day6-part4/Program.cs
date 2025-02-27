using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_part4
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        // arrow function
        static int AddArrow(int a, int b) => a + b;

        static void Main(string[] args)
        {
            // C# Arrow Function (=>)
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(3, 5));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part1_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. lambda function
            string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            var firstName = names.First(n => n.StartsWith("A"));
            Console.WriteLine($"First name starting with A: {firstName}");
        }
    }
}

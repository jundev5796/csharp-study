using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part2_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. sum
            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //foreach (var d in data) sum += d;

            //Console.WriteLine($"Sum: {sum}");

            // ----------------------------------------------------------------------------------------------------

            // 2. count
            int[] data = { 2, 4, 6, 8, 10 };

            int count = data.Length; // finding the length

            Console.WriteLine($"Count: {count}");
        }
    }
}

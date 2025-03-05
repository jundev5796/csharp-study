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

            //// 2. count
            //int[] data = { 2, 4, 6, 8, 10 };

            //int count = data.Length; // finding the length

            //Console.WriteLine($"Count: {count}");

            // ----------------------------------------------------------------------------------------------------

            //// 3. average
            //float[] data = { 1, 2, 3, 4, 5 };

            //double avg = data.Average();

            //Console.WriteLine($"Average: {avg:F2}");

            // ----------------------------------------------------------------------------------------------------

            //// 4. max

            //int[] data = { 10, 3, 5, 2, 8 };

            //int max = data.Max();
            
            //Console.WriteLine($"Max: {max}");

            // ----------------------------------------------------------------------------------------------------

            // 5. min

            int[] data = { 10, 3, 5, 2, 8 };

            int min = data.Min();

            Console.WriteLine($"Min: {min}");
        }
    }
}

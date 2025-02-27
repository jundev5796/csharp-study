using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine(Sum(1, 2, 3));

            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            // 2.
            Console.WriteLine(Factorial(5)); // Factorial(5) = 5 * 4 * 3 * 2 * 1 = 120
        }

        // 1. params
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            return total;
        }

        // 2. recursive function (function that calls itself)
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}

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
            // params
            Console.WriteLine(Sum(1, 2, 3));

            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }

        // params
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            return total;
        }
    }
}

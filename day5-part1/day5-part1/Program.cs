using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// #1 Array

            //// array space starts from 0 not 1
            //int[] num = new int[3]; // create 3 memory (index: 0~2)

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //// declaring array
            //int[] numbers = { 1, 2, 3 }; // simple way of setting size and value
            //int[] numbers1 = new int[3]; // set size only
            //int[] numbers2 = new int[] { 1, 2, 3 }; // set both size and value

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // string array
            string[] fruits = { "Apple", "Banana", "Orange" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}

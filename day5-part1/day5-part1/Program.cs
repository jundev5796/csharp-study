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

            //// string array
            //string[] fruits = { "Apple", "Banana", "Orange" };

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //// 1-dimensional array
            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"Score {i + 1}: {scores[i]}");
            //}

            //// setting decimal points
            //double value = 123.456789;

            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"2 Decimal Points: {value:F2}");
            //Console.WriteLine(String.Format("2 Decimal Points: {0:F2}", value));

            //Console.WriteLine(value.ToString("F0"));

            //double value2 = 123124124.12323;

            //Console.WriteLine(value2.ToString("N2"));

            //// multidimensional array
            //int[,] matrix = new int[2, 3] // 2 sets of 3's
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();
            //}

            // (example)
            int[][] matrix = new int[2][];

            matrix[0] = new int[3];
            matrix[1] = new int[3];

            matrix[0][0] = 1;
            matrix[0][1] = 2;
            matrix[0][2] = 3;

            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}

﻿using System;
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

            //// 5. min

            //int[] data = { 10, 3, 5, 2, 8 };

            //int min = data.Min();

            //Console.WriteLine($"Min: {min}");

            // ----------------------------------------------------------------------------------------------------

            //// 6. near

            //int[] data = { 10, 12, 20, 25, 30 };
            //int target = 22;
            //int nearest = data[0];

            //foreach (var d in data)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target))
            //        nearest = d;
            //}

            //Console.WriteLine($"Nearest to {target}:{nearest}");

            // ----------------------------------------------------------------------------------------------------

            //// 7. rank
            //int[] scores = { 90, 70, 50, 70, 60 };

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    int rank = 1;

            //    for (int j = 0; j < scores.Length; j++)
            //    {
            //        if (scores[j] > scores[i])
            //            rank++;
            //    }

            //    Console.WriteLine($"Score: {scores[i]}, Rank: {rank}");
            //}

            // ----------------------------------------------------------------------------------------------------

            //// 8. sort
            //int[] data = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);

            //foreach (var d in data) Console.WriteLine(d);

            // ----------------------------------------------------------------------------------------------------

            //// 9. search
            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;

            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");

            // ----------------------------------------------------------------------------------------------------

            // 10. group
            // 데이터를 특정 기준으로 그룹화하기
            
            // 문자열 배열 선언 (과일 이름 리스트)
            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            
            // LINQ의 GroupBy()를 사용하여 첫 글자를 기준으로 그룹화
            var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화
            
            // 각 그룹을 순회하며 출력
            foreach (var group in groups)
            {
                // 그룹의 Key (첫 글자) 출력
                Console.WriteLine($"Key : {group.Key}");

                // 해당 그룹에 속한 모든 요소 출력
                foreach (var item in group)
                {
                    Console.WriteLine($" {item}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Problem #1
            //// int형 정수를 5번 입력받아서, 1차원 배열에 저장후
            //// 배열에 저장된 모든 값의 합을 계산하는 알고리즘
            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"숫자 {i + 1} : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine($"배열의 총 합은 {sum}입니다.");
            ////numbers[0] = 1;
            ////numbers[1] = 2;
            ////numbers[2] = 3;
            ////numbers[3] = 4;
            ////numbers[4] = 5;

            ////foreach(var num in numbers)
            ////{
            ////    sum += num;
            ////}

            ////Console.WriteLine($"Sum: {sum}");

            // ----------------------------------------------------------------------------------------------------

            //// Problem #2
            //// 1차원 배열에 저장된 정수 {12, 45, 7, 34, 22}의 정수중
            //// 최대값과 최소값을 찾아 각각 출력하는 프로그램을 만들어주세요.
            //int[] num = { 12, 45, 7, 34, 22 };
            //int max = num[0];
            //int min = num[0];

            //for (int i = 1; i <= num.Length; i++)
            //{
            //    if (max < num[i])
            //        max = num[i];
            //    else if (min > num[i])
            //        min = num[i];
            //}

            //Console.WriteLine($"Max: {max}, Min: {min}");

            // ----------------------------------------------------------------------------------------------------

            //// Problem #3
            //List<int> num = new List<int>();
            //num.Add(1);
            //num.Add(2);
            //num.Add(3);
            //num.Add(4);
            //num.Add(5);

            //Console.WriteLine("Array in Reverse: ");

            //for (int i = num.Count - 1; i >= 0; i--) 
            //{
            //    Console.WriteLine(num[i] + " ");
            //}

            // ----------------------------------------------------------------------------------------------------

            //// 2차원배열
            //// 뭐냐대체
            //// 바로 값을 넣는게 아니면
            //// 길이를 지정해야한다
            //int[,] arr =
            //{
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};

            //for (int y = 0; y < 3; y++)
            //{
            //    for(int x = 0; x < 3; x++)
            //    {
            //        Console.Write(arr[y, x]);
            //    }
            //    Console.WriteLine();
            //}

            // ----------------------------------------------------------------------------------------------------

            //// Problem #4
            //// 2차원 배열
            //// 각 행과 열의 합을 따로 출력하는 프로그램을 만들어주세요.
            //// 1~9까지 할껀데
            //// x축 123, 456, 789합
            //// y축 147, 258, 369합

            //int[,] arr =
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //int y = arr.GetLength(0);
            //int x = arr.GetLength(1);

            //for (int i = 0; i < y; i++)
            //{
            //    int rowSum = 0;

            //    for (int j = 0; j < x; j++)
            //    {
            //        rowSum += arr[i, j];
            //    }
            //    Console.WriteLine($"행의 합: {rowSum}");
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    int colSum = 0;

            //    for (int j = 0; j < y; j++)
            //    {
            //        colSum += arr[j, i];
            //    }
            //    Console.WriteLine($"열의 합: {colSum}");
            //}

            // ----------------------------------------------------------------------------------------------------

            // Problem #5
            // 2차원 배열인데 행의 길이는 2, 열의 길이는 3인 2차원 배열에
            // 1부터 6까지의 숫자를 행과열을 구분해서 출력하기
            int[,] arr =
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            int y = arr.GetLength(0);
            int x = arr.GetLength(1);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(arr[i, j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}

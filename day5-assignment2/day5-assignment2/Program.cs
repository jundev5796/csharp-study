using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace day5_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Array-");


            // Problem #1
            Console.WriteLine("\nProblem #1");
            Console.WriteLine("크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.");

            int[] arrNum = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"{arrNum[0]} {arrNum[1]} {arrNum[2]} {arrNum[3]} {arrNum[4]}");


            // Problem #2
            Console.WriteLine("\nProblem #2");
            Console.WriteLine("사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.");

            int[] arrNum2 = new int[5];
            int sum = 0;

            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                arrNum2[i] = int.Parse(Console.ReadLine());
                sum += arrNum2[i];
            }

            Console.WriteLine($"Total: {sum}");


            // Problem #3
            Console.WriteLine("\nProblem #3");
            Console.WriteLine("정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.");

            int[] arrNum3 = { 3, 8, 15, 6, 2 };
            int max = 0;

            for (int i = 0; i < arrNum3.Length; i++)
            {
                if (max < arrNum3[i])
                {
                    max = arrNum3[i];
                }
            }
            Console.WriteLine($"최대값: {max}");


            Console.WriteLine("\n\n-Loop-");


            // Problem #4
            Console.WriteLine("\nProblem #4");
            Console.WriteLine("for문을 사용하여 1부터 10까지 출력하세요.");

            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");
            }


            // Problem #5
            Console.WriteLine("\n\nProblem #5");
            Console.WriteLine("while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.");

            int j = 1;

            while (j < 11)
            {
                if (j % 2 == 0)
                {
                    Console.Write($"{j} ");
                }
                j++;
            }


            // Problem #6
            Console.WriteLine("\n\nProblem #6");
            Console.WriteLine("foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.");

            int[] arrNum4 = { 1, 2, 3, 4, 5 };

            foreach(int num4 in arrNum4)
            {
                Console.Write($"{num4} ");
            }


            Console.WriteLine("\n\n\n-Function-");


            // Problem #7
            Console.WriteLine("\nProblem #7");
            Console.WriteLine("두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.");

            Console.Write("1st Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("2nd Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = Add(num1, num2);

            Console.WriteLine($"{num1}과(와) {num2}의 합: {result}");


            // Problem #8
            Console.WriteLine("\nProblem #8");
            Console.WriteLine("문자열을 입력받아 길이를 반환하는 함수를 작성하세요.");

            Console.Write("Say Something: ");
            string str = Console.ReadLine();

            int result2 = LongStr(str);

            Console.WriteLine($"문자열 길이: {result2}");


            // Problem #9
            Console.WriteLine("\nProblem #9");
            Console.WriteLine("세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.");

            Console.Write("1st Number: ");
            int max1 = int.Parse(Console.ReadLine());

            Console.Write("2nd Number: ");
            int max2 = int.Parse(Console.ReadLine());

            Console.Write("3rd Number: ");
            int max3 = int.Parse(Console.ReadLine());

            int result3 = MaxNum(max1, max2, max3);

            Console.WriteLine($"가장 큰 수: {result3}");

        }

        // Add Function 
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        // LongStr Function
        static int LongStr(string str)
        {
            return str.Length;
        }


        // MaxInt Function
        static int MaxNum(int max1, int max2, int max3)
        {
            int[] numList = { max1, max2, max3 };
            int maxNum = 0;

            for(int i = 0; i < numList.Length; i++)
            {
                if (maxNum < numList[i])
                {
                    maxNum = numList[i];
                }
            }
            return maxNum;
        }
    }
}

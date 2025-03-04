using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace review_session1
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----Conditional (if/else)-----

            //// Problem #1
            //// 플레이어 점수가 100점 이하면 "레벨업" 아니면 "노력필요" 출력
            //Console.Write("Score: ");
            //int player = int.Parse(Console.ReadLine());

            //if (player <= 100)
            //{
            //    Console.WriteLine("Level Up");
            //}
            //else
            //{
            //    Console.WriteLine("Try Again");
            //}

            //// Problem #2
            //// Debug: F10
            //// 나이가 13세 미만 이면 "어린이 출력", 13세 이상이고, 19세 이하면 "청소년", 그외 "성인"을 출력하세요
            //Console.Write("Age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age < 13)
            //{
            //    Console.WriteLine("Child");
            //}
            //else if (age >= 13 || age <= 19)
            //{
            //    Console.WriteLine("Teen");
            //}
            //else
            //{
            //    Console.WriteLine("Adult");
            //}

            //// Problem #3
            //// switch문을 사용해서 점수등급 (A, B, C, D)에따라 메세지를 출력하세요
            //Console.Write("Grade");
            //string grade = Console.ReadLine();

            //switch (grade)
            //{
            //    case "A": Console.WriteLine("최고"); break;
            //    case "B": Console.WriteLine("좋음"); break;
            //    case "C": Console.WriteLine("보통"); break;
            //    case "D": Console.WriteLine("탈락"); break;
            //}

            //// Problem #4
            //// 12월~2월까지 겨울
            //// 3~4월까지 봄
            //// 6~8월까지 여름
            //// 9~11월까지 가을
            //// 다른숫자가 입력되면 => 잘못 입력되었습니다.
            //Console.Write("Month: ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Winter");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Spring");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Summer");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Fall");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month");
            //        break;
            //}

            // -----For Loop-----
            // for문 -> ~을 위한 -> 목적을 가지고, 어떤 대상에 대해
            // 어떤 특정 목적이나 대상을 정해놓고 그것을 위해 무언가를 수행하는 과정
            // 정해진 횟누나 특정 조건을 만족하는 범위를 대상을 반복하는구조
            // for(초기화; 조건; 증감식)
            // 반복될 내용

            //// Problem #1
            //// for문을 사용해서 1에서 10부터 숫자를 출력해보세요
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// Problem #2
            //int sum = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    sum += i + 1;
            //}
            //Console.WriteLine(sum);

            //// Problem #3
            //// 숫자를 입력받아 입력받은 숫자의 구구단 단수를 출력하세요
            //// Ex. 숫자 2를 입력하면 2 x 1 = 2....2 x 9 = 18 까지 출력하는 알고리즘을 만드세요
            //Console.Write("Number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.WriteLine($"{num} X {i} = {num * i}");
            //}

            // Problem #4
            // * 찍을껀데
            // *
            // **
            // ***
            // ****
            // 이걸 출력하세요
            // 힌트: 가로로도 반복이 들어가고, 세로로도 반복이 들어간다
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

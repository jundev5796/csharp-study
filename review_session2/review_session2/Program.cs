using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace review_session2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// List
            //// Dictionary (key, value)
            //// foreach for
            //// cannot read index
            //// 반복횟수 지정x for문은 가능

            //// Dict -> For Loop
            //Dictionary<string, int> test = new Dictionary<string, int>();
            //test.Add("키", 0);
            //test.Add("키1", 0);
            //test.Add("키2", 0);
            //test.Add("키3", 0);

            //foreach(var data in test)
            //{
            //    Console.WriteLine(data.Key);
            //}

            //string[] player = { "전사", "궁수", "마법사" };

            //for (int i = 0; i < 3; i++)
            //{
            //    if (i == 1) continue;
            //    Console.WriteLine(player[i]);
            //}

            // ----------------------------------------------------------------------------------------------------

            //// Problem #1
            //// 구구단을 2단부터 9단까지 출력
            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 2; j <= 9; j++)
            //    {
            //        Console.Write($"{j} X {i} = {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}

            // ----------------------------------------------------------------------------------------------------

            // while -> ~하는동안
            // while() -> Unity에서 잘 안씀
            // 코루틴

            // ----------------------------------------------------------------------------------------------------

            //// Problem #2
            //// while문으로 숫자를 1에서 5까지 출력하고 종료하는 알고리즘을 만드세요
            //int i = 1;

            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // ----------------------------------------------------------------------------------------------------

            //// Problem #3
            //// 1에서 10까지 합 구하기
            //int sum = 0;
            //int num = 1;

            //while (num <= 10)
            //{
            //    sum += num;
            //    num++;
            //}
            //Console.WriteLine(sum);

            // ----------------------------------------------------------------------------------------------------

            // Problem #4
            // if, switch, while문을 사용해서 가위, 바위, 보 게임을 만들기
            //Random rand = new Random();

            //Console.Write("Choose your pick: ");
            //string player = Console.ReadLine();
            //int random = rand.Next(1, 4);
            //string ai = null;

            //switch (random)
            //{
            //    case 1:
            //        ai = "Rock";
            //        break;
            //    case 2:
            //        ai = "Paper";
            //        break;
            //    case 3:
            //        ai = "Scissor";
            //        break;
            //}

            //if (player == "Rock")
            //{
            //    if (random == 3)
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: You Win!");
            //    }
            //    else if (random == 2)
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: You Lose!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: It is a Draw!");
            //    }
            //}

            //if (player == "Paper")
            //{
            //    if (random == 2)
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: You Win!");
            //    }
            //    else if (random == 3)
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: You Lose!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: It is a Draw!");
            //    }
            //}

            //if (player == "Scissor")
            //{
            //    if (random == 2)
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: You Win!");
            //    }
            //    else if (random == 1)
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: You Lose!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"AI choice: {ai}");
            //        Console.WriteLine("Result: It is a Draw!");
            //    }
            //}

            //Random random = new Random();

            //while (true)
            //{
            //    Console.WriteLine("===가위바위보 게임===");
            //    Console.WriteLine("1:가위, 2:바위, 3:보");
            //    Console.WriteLine("숫자를 입력하세요 :)");

            //    string input = Console.ReadLine();
            //    int useChoice = int.Parse(input);
            //    int computerChoice = random.Next(1, 4);

            //    string userMove = "";
            //    if (useChoice == 1) userMove = "가위";
            //    else if (useChoice == 2) userMove = "바위";
            //    else if (useChoice == 3) userMove = "보";

            //    string computerMove = "";
            //    if (computerChoice == 1) computerMove = "가위";
            //    else if (computerChoice == 2) computerMove = "바위";
            //    else if (computerChoice == 3) computerMove = "보";

            //    Console.WriteLine($"나 : {userMove}, 컴퓨터{computerMove}");

            //    if (useChoice == computerChoice) Console.WriteLine("비겼습둥...\n");
            //    else if ((useChoice == 1 && computerChoice == 3) ||
            //            (useChoice == 2 && computerChoice == 1) ||
            //            (useChoice == 3 && computerChoice == 2))
            //    {
            //        Console.WriteLine("You Win!\n");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You Lose...");
            //    }

            //}

            // ----------------------------------------------------------------------------------------------------

            // Problem #5
            Random random = new Random();
            int number = random.Next(1, 101);

            int userChoice = 0;
            int choiceCount = 0;
            int maxCount = 10;

            Console.WriteLine("숫자맞추기게임!!!!");
            Console.WriteLine("1부터 100까지 숫자를 10번안에 맞춰보세요!!");

            while (true)
            {
                if (choiceCount >= maxCount)
                {
                    Console.WriteLine($"실패했습니다. 정답은 {number}였습니다~~~~");
                    continue;
                }

                string input = Console.ReadLine();
                try
                {
                    userChoice = int.Parse(input);
                }
                catch(FormatException)
                {
                    Console.WriteLine("올바른 숫자를 입력하세요.\n");
                    continue;
                }

                choiceCount++;
                Console.WriteLine("");

                // 
            }

            //Random rand = new Random();
            //int ai = rand.Next(1, 101);
            //int player = int.Parse(Console.ReadLine());

            //while (count > 0)
            //{
            //    Console.WriteLine("===야구게임===");
            //    Console.Write("Guess the number between 1-100: ");
                
                
            //    if (player == ai)
            //    {
            //        Console.WriteLine("Correct :)");
            //        break;
            //    }
            //    else if (player > ai || player < ai)
            //    {
            //        Console.WriteLine("Incorrect, Try Again :(");
            //        count--;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Input");
            //    }
            //}
            //Console.WriteLine("You Win!");
        }
    }
}

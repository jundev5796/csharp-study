using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_assignment
{
    class Program
    {
        //// Problem #1
        //class Warrior
        //{
        //    public string Name { get; set; }
        //    public int Score { get; set; }
        //    public int Strength { get; set; }

        //    public void Stat()
        //    {
        //        Console.WriteLine($"Name: {Name}, Score: {Score}, Strength: {Strength}");
        //    }
        //}

        static void Main(string[] args)
        {
            //// 1.
            //Warrior warrior = new Warrior();
            //warrior.Name = "Lion";
            //warrior.Score = 85;
            //warrior.Strength = 98;
            //warrior.Stat();

            //// Problem #2
            //try
            //{
            //    Console.Write("정수를 입력하세요: ");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"입력결과: {num}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");
            //}

            //// Problem #3
            //List<string> fruits = new List<string>();
            //fruits.Add("사과");
            //fruits.Add("바나나");
            //fruits.Add("포도");
            //Console.WriteLine("과일:");

            //foreach(var fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Queue<string> jobs = new Queue<string>();
            //jobs.Enqueue("첫 번째 작업");
            //jobs.Enqueue("두 번째 작업");
            //jobs.Enqueue("세 번째 작업");
            //Console.WriteLine("\n작업:");

            //while (jobs.Count > 0)
            //{
            //    Console.WriteLine(jobs.Dequeue());
            //}

            //Stack<int> num = new Stack<int>();
            //num.Push(10);
            //num.Push(20);
            //num.Push(30);
            //Console.WriteLine("\n숫자:");

            //while (num.Count > 0)
            //{
            //    Console.WriteLine(num.Pop());
            //}

            //// Problem #4
            //Console.Write("Write Something: ");
            //string str = Console.ReadLine();

            //Console.WriteLine($"1. Uppercase: {str.ToUpper()}");
            //Console.WriteLine($"2. Convert: {str.Replace("C#", "CSharp")}");
            //Console.WriteLine($"3. Length: {str.Length}");

            // Problem #5
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                sum += num;
                Console.Write($"{num} ");
            }
            Console.WriteLine($"\nTotal: {sum}");
        }
    }
}

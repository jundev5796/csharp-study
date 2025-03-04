using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace day8_part1_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Environment
            //Console.WriteLine("Terminate Program");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");

            //Environment.Exit(0); // program ends automatically

            //// 2. Random
            //Random random = new Random();

            //int randomNumber = random.Next(1, 101);
            //Console.WriteLine("Random Number: " + randomNumber);

            //// 3. Saving Runtime
            //Stopwatch stopwatch = Stopwatch.StartNew();

            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1); // 0.001
            //}

            //stopwatch.Stop();

            //Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");

            //// 4. Regular Expression (checking strings for diagnosis)
            //string input = "Hello, my phone number is 010-1234-5678.";
            //string pattern = @"\d{3}-\d{4}-\d{4}"; // phone number pattern

            //bool isMatch = Regex.IsMatch(input, pattern);
            //Console.WriteLine($"Phone Number Exist? {isMatch}");
        }
    }

    //// abstract class
    //public abstract class Animal
    //{
    //    public abstract void MakeSound();
    //}

    //// main class
    //public class Player
    //{
    //    public string Name { get; set; }
    //    public string Score { get; set; }
    //}

    //// inheritence
    //public class Warrior : Player
    //{
    //    public int Strength { get; set; }
    //}

    //// interface
    //public class Enemy: IAttackable, IMovable
    //{
    //    public void Attack() { }
    //    public void Move() { }
    //}
}

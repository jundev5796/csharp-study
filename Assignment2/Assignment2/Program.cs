using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem #1
            Console.Write("Korean: ");
            int scoreKor = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("English: ");
            int scoreEng = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Math: ");
            int scoreMath = int.Parse(Console.ReadLine());
            Console.Clear();

            int sum = scoreKor + scoreEng + scoreMath;
            float avg = sum / 3;

            Console.WriteLine("Score \n");

            Console.WriteLine("Korean: " + scoreKor);
            Console.WriteLine("English: " + scoreEng);
            Console.WriteLine("Math: " + scoreMath + "\n");

            Console.WriteLine("Total: " + sum);
            Console.WriteLine("Average: " + avg.ToString("F2"));
            Console.WriteLine("\n");

            ///////////////////////////////////////////////////////////////////

            // Problem #2
            int num = 0;

            Console.Write("Enter an Integer: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Input: " + num);
            Console.WriteLine("Inverted Value: " + ~num);
        }
    }
}

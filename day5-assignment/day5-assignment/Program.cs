using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day5_assignment
{
    class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            //// Problem #1
            //int[] scoreLit = new int[3];
            //int[] scoreEng = new int[3];
            //int[] scoreMath = new int[3];

            //int[] sum = new int[3];
            //float[] avg = new float[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter Student Score");
            //    Console.Write("Literature: ");
            //    scoreLit[i] = int.Parse(Console.ReadLine());
            //    Console.Write("English: ");
            //    scoreEng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("Math: ");
            //    scoreMath[i] = int.Parse(Console.ReadLine());

            //    sum[i] += scoreLit[i] + scoreEng[i] + scoreMath[i];

            //    avg[i] = (float)sum[i] / 3;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Student #1");
            //    Console.WriteLine($"Literature: {scoreLit[i]} English: {scoreEng[i]} Math: {scoreMath[i]}");
            //    Console.WriteLine("Total: " + sum[i]);
            //    Console.WriteLine("Average: " + avg[i].ToString("F2"));
            //}

            // Problem #2 (function)
            Console.WriteLine("-Adding Numbers-");

            Console.Write("1st Number: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("2nd Number: ");
            int num2 = int.Parse(Console.ReadLine());
            
            int result = Add(num1, num2);

            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }
}

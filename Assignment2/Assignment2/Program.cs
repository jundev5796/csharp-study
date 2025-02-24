using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Problem #1
            //Console.Write("Korean: ");
            //int scoreKor = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.Write("English: ");
            //int scoreEng = int.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.Write("Math: ");
            //int scoreMath = int.Parse(Console.ReadLine());
            //Console.Clear();

            //int sum = scoreKor + scoreEng + scoreMath;
            //float avg = sum / 3;

            //Console.WriteLine("Score \n");

            //Console.WriteLine("Korean: " + scoreKor);
            //Console.WriteLine("English: " + scoreEng);
            //Console.WriteLine("Math: " + scoreMath + "\n");

            //Console.WriteLine("Total: " + sum);
            //Console.WriteLine("Average: " + avg.ToString("F2"));
            //Console.WriteLine("\n");

            /////////////////////////////////////////////////////////////////////

            //// Problem #2
            //int num = 0;

            //Console.Write("Enter an Integer: ");
            //num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Your Input: " + num);
            //Console.WriteLine("Inverted Value: " + ~num);

            /////////////////////////////////////////////////////////////////////

            // Problem #3
            Console.Write("Your Money: ");
            string character = "Lion";
            int money = int.Parse(Console.ReadLine());
            string weapon = default;
            int atk = 0;
            Console.Write("\n");

            if (money >= 0 && money <= 100)
            {
                weapon = "무한의 대검";
                atk += 1;
            }
            else if (money >= 101 && money <= 200)
            {
                weapon = "카타나";
                atk += 2;
            }
            else if (money >= 201 && money <= 300)
            {
                weapon = "진은검";
                atk += 3;
            }
            else if (money >= 301 && money <= 400)
            {
                weapon = "집판검";
                atk += 4;
            }
            else if (money >= 401 && money <= 500)
            {
                weapon = "엑스칼리버";
                atk += 5;
            }
            else if (money >= 501 && money <= 600)
            {
                weapon = "유령검";
                atk += 6;
            }
            else if (money > 600)
            {
                weapon = "전설의 검";
                atk += 7;
            }
            else
            {
                Console.WriteLine("No more choices!");
            }

            string final_weapon = weapon + " " + "+" + atk;

            Console.WriteLine($"Character: {character}");
            Console.WriteLine($"Weapon: {final_weapon}");
        }
    }
}

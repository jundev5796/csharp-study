using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input w/ string
            Console.Write("Write your name: ");
            string userName = Console.ReadLine(); // get input from user

            Console.WriteLine($"Hello, {userName}!");

            // change string to int
            Console.Write("Write your age: ");
            string input = Console.ReadLine(); // get input from user
            int age = int.Parse(input); // string to int

            Console.WriteLine($"You will be {age + 1} next year!"); // output
        }
    }
}

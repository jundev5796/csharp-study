using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            // 2. Random
            Random random = new Random();

            int randomNumber = random.Next(1, 101);
            Console.WriteLine("Random Number: " + randomNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

            // 3. Saving Runtime
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1); // 0.001
            }

            stopwatch.Stop();

            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}

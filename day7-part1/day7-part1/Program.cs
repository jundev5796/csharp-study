using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Built-in Structures
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}"); // current time

            TimeSpan duration = new TimeSpan(1, 30, 0); // time duration (how much time passed)
            Console.WriteLine($"Duration: {duration}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_part5
{
    class Program
    {
        // 1. Enumeration
        enum DayOfWeek
        {
            Sunday, // 0
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // 2. Enum (value change)
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        static void Main(string[] args)
        {
            // 1.
            DayOfWeek today = DayOfWeek.Wednesday;

            Console.WriteLine(today);
            Console.WriteLine((int)today);

            // 2.
            StatusCode status = StatusCode.NotFound;

            Console.WriteLine(status);
            Console.WriteLine((int)status);

            //// Math Class
            //Console.WriteLine($"Pi: {Math.PI}");
            //Console.WriteLine($"Squre root of 25: {Math.Sqrt(25)}");
            //Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");
            //Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");
        }
    }
}

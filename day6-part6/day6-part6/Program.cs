using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_part6
{
    class Program
    {
        // C# Struct (used a lot w/ C++ and Unreal Engine)
        // - similar to class / value type / light and fast
        // - used for simple group of data

        struct Point
        {
            // public (can be used everywhere)
            // private (can only be used by myself)
            public int X;
            public int Y;

            public void Print()
            {
                Console.WriteLine($"Coordinate: {X}, {Y}");
            }
        }

        static void Main(string[] args)
        {
            Point p; // declare struct (need initialization)

            p.X = 10;
            p.Y = 20;

            p.Print();
        }
    }
}

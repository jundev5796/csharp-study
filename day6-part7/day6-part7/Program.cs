using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_part7
{
    struct Rectangle
    {
        public int Width;
        public int Height;

        public int GetArea() => Width * Height;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle { Width = 5, Height = 4 };

            Console.WriteLine($"Area: {rect.GetArea()}");
        }
    }
}

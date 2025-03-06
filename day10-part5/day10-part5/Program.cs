using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part5
{
    class Program
    {
        // ref pointer concept
        // method ref/out
        static void Increase(ref int x)
        {
            x++;
        }

        // out은 반환이 여러개일때 유용하다
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Increase(ref a);
            Console.WriteLine("Value A: " + a); // value connects without return

            int x, y;
            OutFunc(a, b, out x, out y);
            Console.WriteLine("x: " + x + " y: " + y);
        }
    }
}

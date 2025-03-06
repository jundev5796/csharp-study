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

        static void Main(string[] args)
        {
            int a = 10;
            Increase(ref a);

            Console.WriteLine("Value A: " + a); // value connects without return
        }
    }
}

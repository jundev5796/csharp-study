using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_part4_collection
{
    class Program
    {
        // 1. Generic (accepts all types)
        class Cup<T>
        {
            public T Content { get; set; }
        }

        static void Main(string[] args)
        {
            Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            Console.WriteLine($"CupOfString: {cupOfString.Content}");
            Console.WriteLine($"cupOfInt: {cupOfInt.Content}");
        }
    }
}

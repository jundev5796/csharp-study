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
            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString: {cupOfString.Content}");
            //Console.WriteLine($"cupOfInt: {cupOfInt.Content}");

            // w/ stack
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            // w/ list
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

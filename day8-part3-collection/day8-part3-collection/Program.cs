using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_part3_collection
{
    class Program
    {
        // array and collection
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            // 1. list (unlike array which is fixed, it can change size dynamically)
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            names.Add("Dave"); // add name
            names.Remove("Bob"); // remove name

            foreach(var name in names)
            {
                Console.WriteLine(name); // new list for names
            }
        }
    }
}

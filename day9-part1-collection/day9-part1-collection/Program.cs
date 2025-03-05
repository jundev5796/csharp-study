using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part1_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. lambda function
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);

            //foreach (var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var firstName = names.First(n => n.StartsWith("A"));

            //Console.WriteLine($"First name starting with A: {firstName}");

            // ----------------------------------------------------------------------------------------------------

            //// 2. LINQ method/query
            //int[] nums = { 5, 3, 8, 1 };

            //// method
            //var sortedMethod = nums.OrderBy(n => n);

            //// query
            //var sortedQuery = from n in nums
            //                  orderby n
            //                  select n;

            //Console.WriteLine("Method syntax:");
            //foreach (var n in sortedMethod) Console.WriteLine(n);

            //Console.WriteLine("Query syntax:");
            //foreach (var n in sortedQuery) Console.WriteLine(n);

            // ----------------------------------------------------------------------------------------------------

            // 3. select (change type and sort)
            string[] words = { "apple", "banana", "cherry" };

            var lengths = words.Select(w => w.Length);

            foreach (var length in lengths)
            {
                Console.WriteLine(length);
            }

            // Example
            var upperWords = words.Select(w => w.ToUpper());

            foreach (var word in upperWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}

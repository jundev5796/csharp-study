using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_part4_collection
{
    class Program
    {
        //// 1. Generic (accepts all types)
        //class Cup<T>
        //{
        //    public T Content { get; set; }
        //}

        //// 3. custom collection
        //class SimpleCollection: IEnumerable<int>
        //{
        //    private int[] data = { 1, 2, 3, 4, 5 };

        //    public IEnumerator<int> GetEnumerator()
        //    {
        //        foreach(var item in data)
        //        {
        //            yield return item;
        //        }
        //    }
        //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        //}

        static void Main(string[] args)
        {
            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString: {cupOfString.Content}");
            //Console.WriteLine($"cupOfInt: {cupOfInt.Content}");

            //// w/ stack
            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //// w/ list
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //// 2. IEnumerator
            //ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            //IEnumerator enumerator = list.GetEnumerator();

            //while (enumerator.MoveNext()) // checking for next iterator
            //{
            //    Console.WriteLine(enumerator.Current); // output current iterator
            //}

            //// 3.
            //var collection = new SimpleCollection();

            //foreach(var i in collection)
            //{
            //    Console.WriteLine(i);
            //}

            //// 4. dictionary
            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["Gold Axe"] = 10;
            //ages["Silver Axe"] = 5;
            //ages["Stone Axe"] = 1;

            //foreach(var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : { pair.Value}");
            //}

            // 5. null
            // reference types can be null, whereas value types cannot be null by default
            string str = null;

            if (str == null)
            {
                Console.WriteLine("str is null");
            }

            int? nullableInt = null;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            nullableInt = 10;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
        }
    }
}

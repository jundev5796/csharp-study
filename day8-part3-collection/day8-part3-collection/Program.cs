using System;
using System.Collections;
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

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //// 1. list (unlike array which is fixed, it can change size dynamically)
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave"); // add name
            //names.Remove("Bob"); // remove name

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name); // new list for names
            //}

            //// Example
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            ////foreach(int i in list)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////Console.WriteLine(list[1]);
            ////list.Insert(1, 100);
            ////Console.WriteLine(list[1]);

            ////Console.WriteLine(list[0]);

            //list.Insert(1, 100);
            //Console.WriteLine(list.Count);

            //list[2] = 200;

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //// 2. stack (LIFO)
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //// 3. Queue (FILO)
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //// Example
            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("Flash");
            //queue.Enqueue("Attack");

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Console.WriteLine(queue.Count);

            // 4. ArrayList
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1); // integer
            arrayList.Add("Hello"); // string
            arrayList.Add(3.14); // float

            Console.WriteLine("ArrayList: ");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Remove(1);

            Console.WriteLine("\nArrayList w/ remove: ");

            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

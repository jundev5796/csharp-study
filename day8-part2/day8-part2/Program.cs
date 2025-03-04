using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. value/ref types
            //int valueType = 10;
            //object referenceType = valueType; // specifically refers to the "valueType" variable that appears before itself

            //valueType = 20;

            //Console.WriteLine($"ValueType: {valueType}"); // 20
            //Console.WriteLine($"ReferenceType: {referenceType}"); // 19

            //// 2. boxing (converts var into ref and vice-versa)
            //int value = 42;
            //object boxed = value; // boxing
            //int unboxed = (int)boxed; // unboxing

            //Console.WriteLine($"Boxed: {boxed}, Unboxed: {unboxed}");

            //// 3. is (checking if object is a certain type)
            //object obj = "Hello";

            //Console.WriteLine(obj is string); // true
            //Console.WriteLine(obj is int); // false

            //// 4. as (change obj type)
            //object obj = "Hello";
            //string str = obj as string;

            //Console.WriteLine(str is string);

            // Example
            object obj = 42;

            if (obj is int number)
            {
                Console.WriteLine($"Number: {number}");
            }
            else
            {
                Console.WriteLine("Not a Number");
            }
        }
    }
}

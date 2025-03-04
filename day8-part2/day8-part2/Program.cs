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

            //// Example
            //object obj = 42;

            //if (obj is int number)
            //{
            //    Console.WriteLine($"Number: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Number");
            //}

            //// 5. string methods
            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message); // Hello, Alice

            //Console.WriteLine($"Length of name: {name.Length}"); // string length
            //Console.WriteLine($"To Upper: {name.ToUpper()}"); // convert to uppercase
            //Console.WriteLine($"Substring: {name.Substring(1)}"); // part of string

            //string text = "C# is awesome!";
            //Console.WriteLine($"Contains 'awesome': {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#': {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is': {text.IndexOf("is")}");

            // 6. stringbuilder class (advanced string options)
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(","); // add 
            sb.Append("World!");
            Console.WriteLine(sb.ToString());
        }
    }
}

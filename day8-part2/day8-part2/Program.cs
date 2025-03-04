using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //Console.WriteLine($"ReferenceType: {referenceType}"); // 10

            //// 2. boxing (converts var into ref and vice-versa)
            //int value = 42;
            //object boxed = value; // boxing
            //int unboxed = (int)boxed; // unboxing

            //Console.WriteLine($"Boxed: {boxed}, Unboxed: {unboxed}"); // Boxed: 42, Unboxed: 42

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

            //// 6. stringbuilder class (advanced string options)
            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(","); // add 
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());

            //// stringbuilder is useful for repetitive actions
            //int iterations = 10000;

            //Stopwatch sw = Stopwatch.StartNew();

            //string text = "";

            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String: {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}

            //sw.Stop();
            //Console.WriteLine($"StringBuilder: {sw.ElapsedMilliseconds}ms");

            //// 7. exceptions (dealing with exceptions or errors)
            //// catch errors w/o stack overflow
            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[5]); // Error
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 8. finally (runs regardless of exceptions)
            //try
            //{
            //    int number = int.Parse("NotANumber"); // error
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Format Error: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Program Runs");
            //}

            //// 9. exception class
            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"General Error: {ex.Message}");
            //}

            // 10. throw (test with actual error)
            try
            {
                int age = -5;
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exceptoin: {ex.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day4_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// switch
            //int day = 3;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Day");
            //        break;
            //}

            //// for loop
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Number: {i}");
            //}

            // infinite loop
            //int count = 0;
            //while (true)
            //{
            //    Console.WriteLine("Infinite Loop");
            //    count++;
            //    if (count == 3) break; // break loop
            //}

            // while loop
            //int n = 1;
            //while (n <= 5)
            //{
            //    Console.WriteLine($"Number: {n}");
            //    n++;

            //    if (n == 3)
            //    {
            //        Console.WriteLine("Escape at 3");
            //        break;
            //    }
            //}
            //Console.WriteLine($"Count: {n}");

            //// random
            //Random rand = new Random(); // random object

            //int randomNum = rand.Next(0, 11);
            //Console.WriteLine($"Random number between 0 ~ 10: {randomNum}");

            //// random (for loop w/ int)
            //Random rand = new Random(); // random object

            //for (int i = 0; i < 10; i++)
            //{
            //    int randomNum = rand.Next(0, 11);
            //    Console.WriteLine($"Random number between 0 ~ 10: {randomNum}");
            //}

            //// random (for loop w/ float)
            //Random rand = new Random(); // random object

            //for (int i = 0; i < 10; i++)
            //{
            //    int randomNum = rand.Next(0, 11);
            //    Console.WriteLine($"Random number between 0 ~ 10: {randomNum}");
            //}

            //// random (example)
            //Random rand = new Random();

            //int randomInRange = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    randomInRange = rand.Next(5, 15);
            //    Console.WriteLine("5 ~ 14: " + randomInRange);
            //}

            //// do-while loop (not used a lot)
            //int x = 5;

            //do
            //{
            //    Console.WriteLine("run at least once");
            //    x--;
            //} while (x > 0);

            // break
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5) break;
            //    Console.WriteLine(i);
            //}

            // continue
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0) continue; // check for even num
            //    Console.WriteLine(i); // odd num
            //}

            // goto (not used a lot, usually server-side)
            int n = 1;
            start:
            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;

                goto start; // go back to label
            }
        }
    }
}


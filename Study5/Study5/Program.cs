using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study5
{
    class Program
    {
        static void Main(string[] args)
        {
            //// number type
            //int integerNum = 10; // int
            //float floatNum = 3.14f; // short decmial
            //double doubleNum = 3.14159; // long decimal

            //Console.Write(integerNum);
            //Console.Write(floatNum);
            //Console.Write(doubleNum);

            // integer types w/o decimals
            //int intValue = -100; // 4 byte size integer
            //long longValue = 1234567890L; // 8 byte integer

            //Console.WriteLine(intValue); // output: -100
            //Console.WriteLine(longValue); // output: 1234567890

            // integer w/ signs
            sbyte signedByte = -50; // 1 byte size
            short signedShort = -32000; // 2 byte size
            int signedInt = -200000000; // 4 byte size

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);
        }
    }
}

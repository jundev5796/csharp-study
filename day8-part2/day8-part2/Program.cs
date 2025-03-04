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
            // value/ref types
            int valueType = 10;
            object referenceType = valueType; // specifically refers to the "valueType" variable that appears before itself

            valueType = 20;

            Console.WriteLine($"ValueType: {valueType}"); // 20
            Console.WriteLine($"ReferenceType: {referenceType}"); // 19
        }
    }
}

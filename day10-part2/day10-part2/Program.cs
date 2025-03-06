using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part2
{
    class Person
    {
        public string name; // field: a space that contains class data
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); // instance
            p.name = "Alice"; // data inside field
            Console.WriteLine(p.name);
        }
    }
}

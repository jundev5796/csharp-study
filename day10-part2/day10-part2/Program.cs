using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part2
{
    class Person
    {
        private string name; // field: a space that contains class data
        
        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); // instance
            p.SetName("John"); // data inside field
            Console.WriteLine(p.GetName());
        }
    }
}

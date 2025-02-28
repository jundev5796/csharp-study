using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_part2
{
    // 2. Class
    class Person
    {
        public string name;

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(); // create instance
            p1.ShowInfo();
        }
    }
}

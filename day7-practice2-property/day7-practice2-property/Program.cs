using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_practice2_property
{
    class Marine
    {
        public string Name { get; private set; } = "Marine";
        public int Mineral { get; set; } = 100;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Marine m = new Marine();

            Console.WriteLine($"Name: {m.Name}, Mineral: {m.Mineral}");
        }
    }
}

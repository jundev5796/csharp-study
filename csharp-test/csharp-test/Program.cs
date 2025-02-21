using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // character
            int hp = 100; // hp: 100
            double atk = 56.7; // atk: 56.7
            string char_name = "Lion"; // name: Lion
            char class_type = 'S'; // class: S

            Console.WriteLine("Character");
            Console.WriteLine("HP: "+hp); // output: 100
            Console.WriteLine("ATK: "+atk); // output: 56.7
            Console.WriteLine("Name: "+char_name); // output: Lion
            Console.WriteLine("Class: "+class_type); // output: S
        }
    }
}

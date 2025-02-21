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
            //// string
            //string greeting; // declare string variable
            //greeting = "Hello, World!"; // store value in variable

            //// use variable
            //Console.WriteLine(greeting); // outputL: Hello, World!

            //// declare variable + store value
            //int score = 100;
            //double temperature = 36.5;
            //string city = "Seoul";

            //// output
            //Console.WriteLine(score); // output: 100
            //Console.WriteLine(temperature); // output: 36.5
            //Console.WriteLine(city); // output: Seoul

            // declare multiple variables
            //int x = 10, y = 20, z = 30; // declare x, y, z

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            // declare constant variable (fixed variable)
            //const double Pi = 3.14159; // output: 3.14159
            //const int MaxScore = 100; // output: 100

            // character stat
            int atk = 16755;
            int hp = 78103;

            // character ability
            int crit = 36;
            int spec = 1017;
            int subdue = 41;
            int agility = 611;
            int patience = 22;
            int proficiency = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력: "+atk);
            Console.WriteLine("최대 생명력: "+hp);
            Console.WriteLine("--------------------");
            Console.WriteLine("전투 특성");
            Console.WriteLine("치명: "+crit);
            Console.WriteLine("특화: "+spec);
            Console.WriteLine("제압: "+subdue);
            Console.WriteLine("신속: "+agility);
            Console.WriteLine("인내: "+patience);
            Console.WriteLine("숙련: "+proficiency);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part4_inheritance
{
    class Player
    {
        public string name;

        public void Render()
        {
            Console.WriteLine("Player: " + name);
        }
    }

    class Wizard : Player
    {
        public string job;

        public void Render2()
        {
            Console.WriteLine("Job: " + job);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(); // instance

            p.name = "Lion";
            p.Render();


            Wizard w = new Wizard();
            w.name = "Merlin";
            w.job = "Wizard";
            w.Render();
            w.Render2();
        }
    }
}

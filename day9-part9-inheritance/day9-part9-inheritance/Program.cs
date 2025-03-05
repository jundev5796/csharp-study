using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part9_inheritance
{
    class Player
    {
        protected string Name;

        public Player()
        {
            Name = "Player";
            Console.WriteLine("parent instance.");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }
    }

    class Wizard : Player
    {
        public Wizard()
        {
            Name = "Wizard";
            Console.WriteLine("child instance");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Show();

            Wizard w = new Wizard();
            w.Show();
        }
    }
}

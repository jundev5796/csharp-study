using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day7_practice1_class
{
    // create 'marine' unit
    class Marine
    {
        public string Name;
        public int Cost;

        public Marine(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Mineral: {Cost}");
        }
    }

    // create 'scv' unit
    class SCV
    {
        public string Name;
        public int Cost;

        public SCV(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Mineral: {Cost}");
        }
    }

    // create 'barrack' class
    class Barracks
    {
        public string Name;
        public int Cost;

        public Barracks()
        {
            Name = "Barracks";
            Cost = 150;
        }

        public Barracks(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Mineral: {Cost}");
        }
    }

    class Mineral
    {
        public int Amount;

        public Mineral()
        {
            Amount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Amount: {Amount}");
        }
    }

    // creating a 'Game' class
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"Mineral {mineral} Gas {gas} Population {charCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // game instance
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();

            //
            Marine marine = new Marine("Marine", 50);
            SCV scv = new SCV("SCV", 50);
            Barracks barracks = new Barracks();
            Mineral[] mineral = new Mineral[7]; // create 7 arrays

            // new instance in each array
            for (int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }


            marine.ShowInfo();
            scv.ShowInfo();
            barracks.ShowInfo();
        }
    }
}

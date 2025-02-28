using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day7_practice1_class
{
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

    class Program
    {
        static void Main(string[] args)
        {
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

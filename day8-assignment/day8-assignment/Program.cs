﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_assignment
{
    class Program
    {
        // Problem #1
        class Warrior
        {
            public string Name { get; set; }
            public int Score { get; set; }
            public int Strength { get; set; }

            public void Stat()
            {
                Console.WriteLine($"Name: {Name}, Score: {Score}, Strength: {Strength}");
            }
        }

        static void Main(string[] args)
        {
            // 1.
            Warrior warrior = new Warrior();
            warrior.Name = "Lion";
            warrior.Score = 85;
            warrior.Strength = 98;
            warrior.Stat();
        }
    }
}

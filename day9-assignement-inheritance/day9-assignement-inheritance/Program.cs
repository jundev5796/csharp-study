using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day9_assignement_inheritance
{
    class Class
    {
        public string Name;
        public int Health;
        public int Attack;
        public int Defense;
        public int MagAttack;
        public int MagDefense;

        public Class()
        {
            Name = "?";
            Health = 0;
            Attack = 0;
            Defense = 0;
            MagAttack = 0;
            MagDefense = 0;
        }

        public virtual void Attacking()
        {
            Console.WriteLine($"{Name} attacks and inflicts {Attack} damage on enemy.");
        }

        public virtual void Defending()
        {
            Console.WriteLine($"{Name} defends against enemy attack.");
        }

        public virtual void Heal(Class target)
        {
            Console.WriteLine($"{Name} cannot cast heal!");
        }

        public virtual void UseMagic()
        {
            Console.WriteLine($"{Name} cast Firaga on enemy!");
        }

        public virtual void Steal()
        {
            Console.WriteLine($"{Name} steals potion from enemy!");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }
    }

    class Warrior : Class
    {
        public Warrior()
        {
            Name = "Warrior";
            Health = 120;
            Attack = 90;
            Defense = 80;
            MagAttack = 20;
            MagDefense = 30;
        }

        public override void Attacking()
        {
            Console.WriteLine($"Warrior swings sword and heavily deals {Attack} damage on enemy!");
        }

        public override void Defending()
        {
            Console.WriteLine($"Warrior blocks enemy attack!");
        }
    }

    class Thief : Class
    {
        public Thief()
        {
            Name = "Thief";
            Health = 80;
            Attack = 120;
            Defense = 60;
            MagAttack = 20;
            MagDefense = 20;
        }

        public override void Attacking()
        {
            Console.WriteLine($"Thief quickly strikes and deals {Attack} damage on enemy!");
        }

        public override void Defending()
        {
            Console.WriteLine($"Thief blocks enemy attack!");
        }

        public void Steal()
        {
            Console.WriteLine($"Thief steals potion from enemy!"); ;
        }
    }

    class BMage : Class
    {
        public BMage()
        {
            Name = "Black Mage";
            Health = 50;
            Attack = 60;
            Defense = 40;
            MagAttack = 120;
            MagDefense = 100;
        }

        public override void UseMagic()
        {
            Console.WriteLine($"Black Mage cast Firaga and deals {MagAttack} damage on enemy!");
        }

        public override void Defending()
        {
            Console.WriteLine($"Black Mage blocks enemy attack!");
        }
    }

    class WMage : Class
    {
        public WMage()
        {
            Name = "White Mage";
            Health = 40;
            Attack = 50;
            Defense = 30;
            MagAttack = 100;
            MagDefense = 90;
        }

        public override void UseMagic()
        {
            Console.WriteLine($"White Mage cast Holy and deals {MagAttack} damage on enemy!");
        }

        public override void Heal(Class target)
        {
            Console.WriteLine($"White Mage cast Heal on {target.Name}!");
        }

        public override void Defending()
        {
            Console.WriteLine($"White Mage blocks enemy attack!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Class> characters = new List<Class>();

            // upcasting
            characters.Add(new Warrior());
            characters.Add(new Thief());

            foreach (var character in characters)
            {
                character.Move();
                character.Attacking();
                character.Defending();
                Console.WriteLine();
            }

            Thief thief = new Thief();
            thief.Steal();
            Console.WriteLine();

            BMage bMage = new BMage();
            bMage.UseMagic();
            bMage.Defending();
            Console.WriteLine();

            WMage wMage = new WMage();
            wMage.UseMagic();
            wMage.Defending();
            wMage.Heal(characters[0]);
        }
    }
}

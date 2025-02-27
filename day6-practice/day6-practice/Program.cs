using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_practice
{
    class Program
    {
        // Problem #1
        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        static void ChooseWeapon(WeaponType weapon)
        {
            if (weapon == WeaponType.Sword)
            {
                Console.WriteLine("You chose a Sword!");
            }
            else if (weapon == WeaponType.Bow)
            {
                Console.WriteLine("You chose a Bow!");
            }
            else if (weapon == WeaponType.Staff)
            {
                Console.WriteLine("You chose a Staff!");
            }
        }

        static void Main(string[] args)
        {
            // 1.
            ChooseWeapon(WeaponType.Staff);
        }
    }
}

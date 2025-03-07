using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _day11_test__TextRPG
{
    public class Enemy
    {
        public INFO enemy;

        public void SetDamage(int iAttack)
        {
            enemy.iHp -= iAttack;
        }

        public void SetEnemy(INFO tEnemy)
        {
            enemy = tEnemy;
        }

        public INFO GetEnemy()
        {
            return enemy;
        }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"이름: {enemy.sName}");
            Console.WriteLine($"HP: {enemy.iHp}");
            Console.WriteLine($"ATK: {enemy.iAttack}");
        }

        public Enemy() { }

        ~Enemy() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_practice_TEXTRPG
{
    class Monster
    {
        public INFO monster;

        public void SetDamage(int iAttack) { monster.iHp -= iAttack; }

        public INFO GetMonster() { return monster; }

        public void SetMonster(INFO tMonster) { monster = tMonster; }

        public void Render()
        {
            Console.WriteLine("=====몬스터 정보=====");
            Console.WriteLine($"이름: {monster.sName}");
            Console.WriteLine($"HP: {monster.iHp}");
            Console.WriteLine($"ATK: {monster.iAttack}");
        }

        public Monster() { }

        ~Monster() { }
    }
}

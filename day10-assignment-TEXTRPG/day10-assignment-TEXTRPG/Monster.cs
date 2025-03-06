using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_assignment_TEXTRPG
{
    class Monster
    {
        public Stat monsterStat;

        public void SetDamage(int iAttack)
        {
            monsterStat.iHp -= iAttack;
        }

        public void SetMonster(Stat tMonster)
        {
            monsterStat = tMonster;
        }

        public Stat GetMonster()
        {
            return monsterStat;
        }

        public void RenderStat()
        {
            Console.WriteLine("====몬스터 정보====");
            Console.WriteLine($"직업: {monsterStat.Name}");
            Console.WriteLine($"HP: {monsterStat.iHp}");
            Console.WriteLine($"ATK: {monsterStat.iAttack}");
        }

        public Monster() { }

        ~Monster() { }
    }
}

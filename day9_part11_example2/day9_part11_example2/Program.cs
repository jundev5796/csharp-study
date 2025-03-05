using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part11_example2
{
    class Skill
    {
        public string Name; // skill name
        public int ManaCost; // mana usage
        public int Cooldown;
        public int LastUsedTime;

        public Skill(string name, int manaCost, int cooldown)
        {
            Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 100;
            LastUsedTime = 0;
        }

        // 스킬 사용 가능 여부 확인
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

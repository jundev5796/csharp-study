using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_assignment_TEXTRPG
{
    class Player
    {
        public Stat playerStat;

        public void SetDamage(int iAttack)
        {
            playerStat.iHp -= iAttack;
        }

        public Stat GetInfo()
        {
            return playerStat;
        }

        public void SetHp(int iHp) 
        {
            playerStat.iHp = iHp;
        }

        public void SelectJob()
        {
            playerStat = new Stat();

            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 도적");
            Console.Write("직업을 선택해 주세요: ");
            int jobChoice = int.Parse(Console.ReadLine());

            switch (jobChoice)
            {
                case 1:
                    playerStat.Name = "전사";
                    playerStat.iHp = 120;
                    playerStat.iAttack = 20;
                    break;
                case 2:
                    playerStat.Name = "마법사";
                    playerStat.iHp = 70;
                    playerStat.iAttack = 40;
                    break;
                case 3:
                    playerStat.Name = "도적";
                    playerStat.iHp = 90;
                    playerStat.iAttack = 30;
                    break;
            }
        }

        public void RenderStat()
        {
            Console.WriteLine("====캐릭터 정보====");
            Console.WriteLine($"직업: {playerStat.Name}");
            Console.WriteLine($"HP: {playerStat.iHp}");
            Console.WriteLine($"ATK: {playerStat.iAttack}");
        }

        public Player() { }

        ~Player() { }
    }
}

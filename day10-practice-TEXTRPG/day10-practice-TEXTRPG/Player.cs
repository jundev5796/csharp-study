using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day10_practice_TEXTRPG
{
    public class Player
    {
        public INFO player;

        public void SetDamage(int iAttack) { player.iHp -= iAttack; }

        public INFO GetInfo() { return player; }

        public void SetHp(int iHp) { player.iHp = iHp; }

        public void SelectJob()
        {
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 도적");
            Console.Write("어떤 직업을 선택하시겠습니까? ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    player.sName = "기사";
                    player.iHp = 100;
                    player.iAttack = 10;
                    break;
                case 2:
                    player.sName = "마법사";
                    player.iHp = 90;
                    player.iAttack = 15;
                    break;
                case 3:
                    player.sName = "도적";
                    player.iHp = 85;
                    player.iAttack = 12;
                    break;
            }
        }
        
        public void Render()
        {
            Console.WriteLine("=====플레이어 정보=====");
            Console.WriteLine($"이름: {player.sName}");
            Console.WriteLine($"HP: {player.iHp}");
            Console.WriteLine($"ATK: {player.iAttack}");
        }

        public Player() { }
        
        ~Player() { }
    }
}

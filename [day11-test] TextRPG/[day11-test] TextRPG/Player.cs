using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _day11_test__TextRPG
{
    public class Player
    {
        public INFO player = new INFO();

        public void SetDamage(int iAttack)
        {
            player.iHp -= iAttack;
        }

        public void SetHp(int iHp)
        {
            player.iHp = iHp;
        }

        public INFO GetInfo()
        {
            return player;
        }

        public void CharSelect()
        {
            Console.WriteLine("========젠레스 존 제로 RPG========");
            Console.WriteLine($"1. 미야비");
            Console.WriteLine($"2. 야나기");
            Console.WriteLine($"3. 제인");
            Console.WriteLine($"4. 아스트라");
            Console.WriteLine($"5. 카이사르");
            Console.Write("어떤 캐릭터를 선택하시겠습니까? ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    player.sName = "미야비";
                    player.iHp = 100;
                    player.iAttack = 250;
                    break;
                case 2:
                    player.sName = "야나기";
                    player.iHp = 90;
                    player.iAttack = 190;
                    break;
                case 3:
                    player.sName = "제인";
                    player.iHp = 80;
                    player.iAttack = 180;
                    break;
                case 4:
                    player.sName = "아스트라";
                    player.iHp = 60;
                    player.iAttack = 160;
                    break;
                case 5:
                    player.sName = "카이사르";
                    player.iHp = 200;
                    player.iAttack = 140;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"이름: {player.sName}");
            Console.WriteLine($"HP: {player.iHp}");
            Console.WriteLine($"ATK: {player.iAttack}");
        }

        public Player() { }

        ~Player() { }
    }
}

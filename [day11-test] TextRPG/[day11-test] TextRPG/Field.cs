using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _day11_test__TextRPG
{
    public class Field
    {
        Player player = null;
        Enemy enemy = null;

        public void SetPlayer(ref Player pPlayer)
        {
            player = pPlayer;
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                player.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                if (iInput <= 3)
                {
                    CreateEnemy(iInput);
                    Fight();
                }
            }
        }

        public void Create(string sName, int iHp, int iAttack, out Enemy pEnemy)
        {
            pEnemy = new Enemy();
            INFO tEnemy = new INFO();

            tEnemy.sName = sName;
            tEnemy.iHp = iHp;
            tEnemy.iAttack = iAttack;

            pEnemy.SetEnemy(tEnemy);
        }

        public void CreateEnemy(int input)
        {
            switch (input)
            {
                case 1:
                    {
                        Create("하급 에테리얼", 100, 3, out enemy);
                        break;
                    }
                case 2:
                    {
                        Create("중급 에테리얼", 200, 6, out enemy);
                        break;
                    }
                case 3:
                    {
                        Create("상급 에테리얼", 300, 9, out enemy);
                        break;
                    }
            }
        }

        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                player.Render();
                enemy.Render();

                Console.WriteLine("1. 전투");
                Console.WriteLine("2. 후퇴");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    player.SetDamage(enemy.GetEnemy().iAttack);
                    enemy.SetDamage(player.GetInfo().iAttack);

                    if (player.GetInfo().iHp <= 0)
                    {
                        player.SetHp(100);
                        break;
                    }
                }

                if (iInput == 2 || enemy.GetEnemy().iHp <= 0)
                {
                    enemy = null;
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 발레 빌딩 에테리얼 소탕");
            Console.WriteLine("2. 외환선 재료 탐색");
            Console.WriteLine("3. 제로공동 물건 회수");
            Console.WriteLine("4. 종료");
            Console.WriteLine("============================");
            Console.WriteLine("의뢰를 선택해주세요: ");
        }

        public Field() { }

        ~Field() { }
    }
}

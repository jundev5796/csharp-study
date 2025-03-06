using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_assignment_TEXTRPG
{
    class MainGame
    {
        public Player player = null;
        public Field field = null;

        public void Initialize()
        {
            player = new Player();
            player.SelectJob();
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                player.RenderStat(); // 플레이어 출력
                Console.WriteLine("1.사냥터 2.종료 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2)
                    break;

                if (iInput == 1)
                {
                    // 사냥터 구현
                    if (field == null)
                    {
                        field = new Field();

                        // 필드로 갈때 플레이어 넣어주기
                        field.SetPlayer(ref player);
                    }
                    field.Progress();

                }
            }
        }
        public MainGame() { }

        ~MainGame() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_practice_TEXTRPG
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
                player.Render();
                Console.Write("1. 사냥터 2. 종료: ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2)
                    break;

                if (iInput == 1)
                {
                    if (field == null)
                    {
                        field = new Field();

                        field.SetPlayer(ref player);
                    }
                    field.Progress();
                }
            }
        }
    }
}

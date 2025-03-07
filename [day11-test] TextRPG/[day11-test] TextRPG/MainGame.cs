using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _day11_test__TextRPG
{
    class MainGame
    {
        public Player player = null;
        public Field field = null;

        public void Initialize()
        {
            player = new Player();
            player.CharSelect();
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("1. 의뢰 시작");
                Console.WriteLine("2. 종료");
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

        public MainGame() { }

        ~MainGame() { }
    }
}

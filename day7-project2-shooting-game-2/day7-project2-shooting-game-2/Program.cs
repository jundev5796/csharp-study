using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_Game_Practice
{
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;

        public Player()
        {
            playerX = 0;
            playerY = 12;
        }

        public void PlayerCreate()
        {
            string[] player = new string[]
            {
                "==>",
                ">>>>",
                "==>"
            };

            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }

        public void PlayerMove()
        {
            int key;

            if (Console.KeyAvailable)
            {
                key = _getch();

                if (key == 0 || key == 224 )
                {
                    key = _getch();
                }

                switch(key)
                {
                    case 72:
                        playerY--;
                        break;
                }
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player();
            player.PlayerCreate();
        }
    }
}

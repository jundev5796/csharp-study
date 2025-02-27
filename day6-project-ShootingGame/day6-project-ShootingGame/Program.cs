using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_project_ShootingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            int x = 10, y = 10;

            ConsoleKeyInfo keyInfo;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear(); // 화면 지우기

                Console.SetCursorPosition(x, y);

                Console.Write("●"); // 현재 위치 출력

                keyInfo = Console.ReadKey(true); // 키 입력 받기 (화면 출력 X)

                // 방향키 입력에 따른 좌표 병경
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowHeight - 1) x++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: return; // ESC키로 종료
                }
            }
        }
    }
}

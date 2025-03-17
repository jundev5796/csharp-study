using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session_2048Game
{
    /// <summary>
    /// GameManager 클래스는 2048 게임의 전체 흐름을 관리합니다.
    /// 사용자 입력 처리, 보드 이동, 새로운 타일 스폰 및 게임 오버 검사 등을 담당합니다.
    /// </summary>
    public class GameManager
    {
        private Board board;       // 게임 보드
        private bool gameOver;     // 게임 종료 플래그

        /// <summary>
        /// 생성자: Board를 초기화하고 게임 상태를 설정합니다.
        /// </summary>
        public GameManager()
        {
            board = new Board();
            gameOver = false;
        }

        /// <summary>
        /// 게임 루프를 실행합니다.
        /// </summary>
        public void Run()
        {
            while (!gameOver)
            {
                board.PrintBoard(); // 현재 보드 출력
                Console.WriteLine("W: 위, A: 왼쪽, S: 아래, D: 오른쪽");
                Console.Write("이동 방향 입력: ");
                char input = Char.ToLower(Console.ReadKey(true).KeyChar);
                bool moved = false;

                // 입력에 따라 보드 이동 처리
                switch (input)
                {
                    case 'w':
                        moved = board.MoveUp();
                        break;
                    case 'a':
                        moved = board.MoveLeft();
                        break;
                    case 's':
                        moved = board.MoveDown();
                        break;
                    case 'd':
                        moved = board.MoveRight();
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }

                // 이동이 성공적으로 이루어졌다면, 새로운 타일 스폰
                if (moved)
                {
                    board.SpawnTile();
                }
                else
                {
                    // 이동이 없고 보드에 더 이상 이동할 수 없으면 게임 오버
                    if (!board.CanMove())
                    {
                        gameOver = true;
                    }
                }
            }

            board.PrintBoard();
            Console.WriteLine("Game Over!");
            Console.ReadKey();
        }
    }
}

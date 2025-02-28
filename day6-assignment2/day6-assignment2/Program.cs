using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ShootingGame_Refactored
{
    struct Player
    {
        public int X, Y;
        public string[] player;

        pubilc Player(int a, int b)
        {
            X = a;
            Y = b;
            player = new string[]
            {
                "->",
                ">>>",
                "->",
            };
        }

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초
        }
    }
    ////Player 구조체를 생성.
    ////player 함수 선언 후, 함수 내부에 플레이어의 초기 위치와 shape 배열로 플레이어 저장.
    //struct Player
    //{
    //    public int X, Y;
    //    public string[] Shape;

    //    public Player(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //        Shape = new string[]
    //        {
    //            "->",
    //            ">>>",
    //            "->"
    //        };
    //    }

    //    //switch 문으로 플레이어의 움직임을 상하좌우로 조작하는 Move 함수 추가
    //    public void Move(ConsoleKey key)
    //    {
    //        switch (key)
    //        {
    //            case ConsoleKey.UpArrow: if (Y > 0) Y--; break;
    //            case ConsoleKey.DownArrow: if (Y < Console.WindowHeight - Shape.Length) Y++; break;
    //            case ConsoleKey.LeftArrow: if (X > 0) X--; break;
    //            case ConsoleKey.RightArrow: if (X < Console.WindowWidth - 3) X++; break;
    //        }
    //    }

    //    //미사일 출력 함수 Draw
    //    public void Draw()
    //    {
    //        for (int i = 0; i < Shape.Length; i++)
    //        {
    //            Console.SetCursorPosition(X, Y + i);
    //            Console.Write(Shape[i]);
    //        }
    //    }
    //}

    ////player가 출력하게 되는 미사일을 구조체 Missile로 묶어서 표현.
    ////Missile 함수로 초기 위치 선언 및 
    //struct Missile
    //{
    //    public int X, Y;

    //    public Missile(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    // Move를 선언하여 오른쪽으로 이동
    //    public void Move()
    //    {
    //        X++;
    //    }

    //    public void Draw()
    //    {
    //        Console.SetCursorPosition(X, Y);
    //        Console.Write("-");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        int width = Math.Min(80, Console.LargestWindowWidth);
    //        int height = Math.Min(25, Console.LargestWindowHeight);
    //        Console.SetWindowSize(width, height);
    //        Console.SetBufferSize(width, height);
    //        Console.CursorVisible = false;

    //        Player player = new Player(0, 12);

    //        List<Missile> missiles = new List<Missile>();

    //        Stopwatch timer = new Stopwatch();
    //        timer.Start();
    //        long prevSecond = timer.ElapsedMilliseconds;

    //        while (true)
    //        {
    //            long currentSecond = timer.ElapsedMilliseconds;

    //            if (currentSecond - prevSecond >= 100)
    //            {
    //                Console.Clear();
    //                prevSecond = currentSecond;

    //                if (Console.KeyAvailable)
    //                {
    //                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    //                    if (keyInfo.Key == ConsoleKey.Spacebar)
    //                    {
    //                        missiles.Add(new Missile(player.X + 3, player.Y + 1));
    //                    }
    //                    else if (keyInfo.Key == ConsoleKey.Escape)
    //                    {
    //                        return;
    //                    }
    //                    else
    //                    {
    //                        player.Move(keyInfo.Key);
    //                    }
    //                }

    //                // 미사일 이동
    //                for (int i = 0; i < missiles.Count; i++)
    //                {
    //                    missiles[i] = new Missile(missiles[i].X + 1, missiles[i].Y);
    //                }
    //                // 화면 밖으로 나간 미사일 제거
    //                missiles.RemoveAll(m => m.X >= Console.WindowWidth);

    //                player.Draw();

    //                foreach (var missile in missiles)
    //                {
    //                    missile.Draw();
    //                }

    //                Thread.Sleep(50);
    //            }
    //        }
    //    }
    //}
}

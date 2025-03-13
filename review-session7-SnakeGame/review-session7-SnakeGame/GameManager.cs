﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session7_SnakeGame
{
    class GameManager
    {
        //보드의 가로크기
        private const int BoardWidth = 40;
        //보드의 세로크기
        private const int BoardHeight = 20;
        //보드의 상태를 저장할 2차원배열
        private char[,] board;
        private Snake snake;
        private Point food;
        private bool gameOver;
        private Random random;

        private void PlaceFood()
        {
            int x, y;

            do
            {
                x = random.Next(0, BoardWidth);
                y = random.Next(0, BoardHeight);
            } while (snake.Contains(new Point(x, y)));
            food = new Point(x, y);
        }

        public GameManager()
        {
            board = new char[BoardHeight, BoardWidth];
            snake = new Snake(BoardWidth / 2, BoardHeight / 2);
            random = new Random();
            gameOver = false;
            PlaceFood();
        }

        private void Draw()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < BoardHeight; i++)
            {
                for (int j = 0; j < BoardWidth; j++)
                {
                    board[i, j] = ' ';

                }
            }

            foreach (var p in snake.Body)
            {
                if (p.X >= 0 && p.X < BoardWidth && p.Y >= 0 && p.Y < BoardHeight)
                    board[p.Y, p.X] = 'O';
            }

            board[food.Y, food.X] = '*';

            string YBoard = new string('#', BoardWidth + 2);
            Console.WriteLine(YBoard);
            for (int i = 0; i < BoardHeight; i++)
            {
                Console.Write("#");
                for (int j = 0; j < BoardWidth; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine("#");
            }
            Console.WriteLine(YBoard);
        }

        private bool IsOpposite(Direction d1, Direction d2)
        {
            return (d1 == Direction.Up && d2 == Direction.Down ||
                d1 == Direction.Down && d2 == Direction.Up ||
                d1 == Direction.Left && d2 == Direction.Right ||
                d1 == Direction.Right && d2 == Direction.Left);
        }


        private void Input()
        {
            if (Console.KeyAvailable) //키입력이 있는지 확인하는 비차단방식
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Direction newDirection = snake.CurrentDirection;

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        newDirection = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        newDirection = Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        newDirection = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        newDirection = Direction.Right;
                        break;
                }

                //스네이크가 반대방향으로 회전하는것 방지
                if (!IsOpposite(newDirection, snake.CurrentDirection))
                {
                    snake.CurrentDirection = newDirection;
                }
            }
        }

        private void Update()
        {
            Point NewHead = snake.Move(false);

            //벽과 충돌체크
            if (NewHead.X < 0 || NewHead.X > BoardWidth || NewHead.Y < 0 || NewHead.Y >= BoardHeight)
            {
                gameOver = true;
                return;
            }

            //자기 자신이랑 충돌체크
            for (int i = 1; i < snake.Body.Count; i++)
            {
                if (snake.Body[i].X == NewHead.X && snake.Body[i].Y == NewHead.Y)
                {
                    gameOver = true;
                    return;
                }
            }
            //먹이랑 충돌체크
            if (NewHead.X == food.X && NewHead.Y == food.Y)
            {
                snake.Move(true);
                PlaceFood();
            }
        }

        public void Run()
        {
            int Curr = Environment.TickCount;
            Console.CursorVisible = false;
            while (!gameOver)
            {
                if (Curr + 100 < Environment.TickCount)
                {
                    Curr = Environment.TickCount;

                    Draw();
                    Input();
                    Update();
                }
            }
            Console.WriteLine("게임오버");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day4_console_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.SetWindowSize(100, 50);

            Console.SetBufferSize(100, 50);

            Console.CursorVisible = false;


            Console.SetCursorPosition(50, 8);
            Console.WriteLine("     -SNAKE-     ");
            Console.SetCursorPosition(49, 12);
            Console.WriteLine("Press Enter to Play");
            Console.ReadLine();
            Console.Clear();

            Console.SetWindowSize(30, 20);
            Console.SetBufferSize(30, 20);
            Console.CursorVisible = false;

            int width = 28, height = 18;
            int snakeX = width / 2, snakeY = height / 2;
            int foodX = 5, foodY = 5;
            int length = 1;
            int[,] snake = new int[100, 2]; // Snake body positions
            snake[0, 0] = snakeX;
            snake[0, 1] = snakeY;
            char direction = 'd';

            Random rand = new Random();
            bool running = true;

            // Draw the box
            for (int x = 0; x < width; x++) { Console.SetCursorPosition(x, 0); Console.Write("█"); }
            for (int x = 0; x < width; x++) { Console.SetCursorPosition(x, height); Console.Write("█"); }
            for (int y = 0; y < height; y++) { Console.SetCursorPosition(0, y); Console.Write("█"); }
            for (int y = 0; y < height; y++) { Console.SetCursorPosition(width, y); Console.Write("█"); }

            Console.SetCursorPosition(foodX, foodY);
            Console.Write("O");

            while (running)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.W && direction != 's') direction = 'w';
                    if (key.Key == ConsoleKey.S && direction != 'w') direction = 's';
                    if (key.Key == ConsoleKey.A && direction != 'd') direction = 'a';
                    if (key.Key == ConsoleKey.D && direction != 'a') direction = 'd';
                }

                // Move the snake's body
                for (int i = length; i > 0; i--)
                {
                    snake[i, 0] = snake[i - 1, 0];
                    snake[i, 1] = snake[i - 1, 1];
                }

                // Move the snake's head
                if (direction == 'w') snakeY--;
                if (direction == 's') snakeY++;
                if (direction == 'a') snakeX--;
                if (direction == 'd') snakeX++;

                snake[0, 0] = snakeX;
                snake[0, 1] = snakeY;

                // Check for collision with walls
                if (snakeX == 0 || snakeX == width || snakeY == 0 || snakeY == height)
                {
                    running = false;
                }

                // Check for collision with itself
                for (int i = 1; i < length; i++)
                {
                    if (snakeX == snake[i, 0] && snakeY == snake[i, 1])
                    {
                        running = false;
                    }
                }

                // Check if snake eats food
                if (snakeX == foodX && snakeY == foodY)
                {
                    length++;
                    foodX = rand.Next(1, width - 1);
                    foodY = rand.Next(1, height - 1);
                }

                // Redraw the game
                Console.Clear();

                // Draw the box
                for (int x = 0; x < width; x++) { Console.SetCursorPosition(x, 0); Console.Write("█"); }
                for (int x = 0; x < width; x++) { Console.SetCursorPosition(x, height); Console.Write("█"); }
                for (int y = 0; y < height; y++) { Console.SetCursorPosition(0, y); Console.Write("█"); }
                for (int y = 0; y < height; y++) { Console.SetCursorPosition(width, y); Console.Write("█"); }

                Console.SetCursorPosition(foodX, foodY);
                Console.Write("■");

                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(snake[i, 0], snake[i, 1]);
                    Console.Write("■");
                }

                Thread.Sleep(100);
            }

            Console.SetCursorPosition(width / 2 - 5, height / 2);
            Console.Write("Game Over!");
            Console.ReadLine();
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.SetWindowSize(100, 50);

            //Console.SetBufferSize(100, 50);

            //Console.CursorVisible = false;


            //Console.SetCursorPosition(50, 8);
            //Console.WriteLine("     -SNAKE-     ");
            //Console.SetCursorPosition(49, 12);
            //Console.WriteLine("Press Enter to Play");
            //Console.ReadLine();
            //Console.Clear();

            //for (int x = 0; x < 80; x++) // Move from 0~29
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 30);
            //    Console.Write("⬛");
            //    Console.SetCursorPosition(x, 30);
            //    Console.Write("⬛");
            //    Thread.Sleep(100);
            //}





            //Console.SetCursorPosition(0, 1);
            //Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        }
    }
}

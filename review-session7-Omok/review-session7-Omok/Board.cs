using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session7_Omok
{
    class Board
    {
        public const int Size = 15; // 15 X 15
        public const char EmptyCell = '.';
        private char[,] cells; //보드의 상태를 저장할 2차원배열

        public (int row, int col)? LastMove { get; private set; }

        public Board()
        {
            cells = new char[Size, Size];
            Initialize();
        }

        public void Initialize()
        {
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    cells[r, c] = EmptyCell;
                }
            }
            LastMove = null;
        }

        public void Print()
        {
            Console.Clear();

            Console.Write("   ");
            for (int col = 0; col < Size; col++)
            {
                Console.Write($"{col,2} ");
            }
            Console.WriteLine();

            for (int row = 0; row < Size; row++)
            {
                Console.Write($"{row,2} ");
                for (int col = 0; col < Size; col++)
                {
                    Console.Write($" {cells[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        public bool PlaceStone(int row, int col, char stone)
        {
            if (!IsValidCoordinate(row, col))
            {
                return false;
            }
            if (cells[row, col] != EmptyCell)
            {
                return false;
            }

            cells[row, col] = stone;
            LastMove = (row, col);
            return true;
        }




        public bool IsValidCoordinate(int row, int col)
        {
            return row >= 0 && row < Size && col >= 0 && col < Size;
        }

        private int CountConsecutive(int startRow, int startCol, int dRow, int dCol, char stone)
        {
            int count = 0;
            int r = startRow + dRow, c = startCol + dCol;
            while (IsValidCoordinate(r, c) && cells[r, c] == stone)
            {
                count++;
                r += dRow;
                c += dCol;
            }

            return count;
        }

        public bool CheckWin(char stone)
        {
            int[][] direction = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 1, 1 },
                new int[] { -1, -1 }
            };

            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    if (cells[r, c] != stone) continue;

                    foreach (var dir in direction)
                    {
                        int count = 1;
                        count += CountConsecutive(r, c, dir[0], dir[1], stone);
                        count += CountConsecutive(r, c, -dir[0], -dir[1], stone);
                        if (count >= 5) return true;
                    }
                }
            }
            return false;
        }


        //빈칸의 목록을 반환해주는 함수
        public List<(int row, int col)> GetEmptyCells()
        {
            List<(int row, int col)> emptyCells = new List<(int row, int col)>();

            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    if (cells[r, c] == EmptyCell)
                    {
                        emptyCells.Add((r, c));
                    }
                }
            }
            return emptyCells;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session7_Omok
{
    class AIPlayer
    {
        private Random random = new Random();

        public (int row, int col) GetMove(Board board)
        {
            List<(int row, int col)> enmptyCells = board.GetEmptyCells();
            if (enmptyCells.Count == 0) return (-1, -1);

            List<(int row, int col)> closeCells = new List<(int, int)>();

            if (board.LastMove.HasValue)
            {
                var (lastRow, lastCol) = board.LastMove.Value;
                foreach (var cell in enmptyCells)
                {
                    if (Math.Abs(cell.row - lastRow) <= 1 && Math.Abs(cell.col - lastCol) <= 1)
                    {
                        closeCells.Add(cell);
                    }
                }
            }

            if (closeCells.Count > 0)
            {
                int index = random.Next(closeCells.Count);
                return closeCells[index];
            }
            else
            {
                int index = random.Next(enmptyCells.Count);
                return enmptyCells[index];
            }



        }
    }
}

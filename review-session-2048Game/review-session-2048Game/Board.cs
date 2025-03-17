using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session_2048Game
{
    /// <summary>
    /// Board 클래스는 2048 게임의 보드를 관리합니다.
    /// 4×4 배열을 사용하며, 타일 이동, 병합, 새로운 타일 스폰 및 이동 가능 여부 판단 등의 기능을 제공합니다.
    /// </summary>
    public class Board
    {
        public const int Size = 4;              // 보드의 크기 (4x4)
        public int[,] Grid { get; private set; }  // 보드 상태 (0은 빈 칸)
        private Random random;                  // 무작위 타일 스폰을 위한 Random 객체

        /// <summary>
        /// 생성자: 보드를 초기화하고, 두 개의 타일을 스폰합니다.
        /// </summary>
        public Board()
        {
            Grid = new int[Size, Size];
            random = new Random();
            Initialize();
        }

        /// <summary>
        /// 보드를 0(빈 칸)으로 초기화하고, 초기 타일 2개를 스폰합니다.
        /// </summary>
        public void Initialize()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i, j] = 0;
                }
            }
            SpawnTile();
            SpawnTile();
        }

        /// <summary>
        /// 보드의 빈 칸 중 무작위로 하나를 선택하여 타일을 스폰합니다.
        /// 90% 확률로 2, 10% 확률로 4를 생성합니다.
        /// </summary>
        public void SpawnTile()
        {
            List<(int row, int col)> emptyCells = new List<(int, int)>();

            // 빈 칸 찾기
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (Grid[i, j] == 0)
                        emptyCells.Add((i, j));
                }
            }

            // 빈 칸이 없으면 아무것도 하지 않음
            if (emptyCells.Count == 0)
                return;

            // 무작위 빈 칸 선택
            var cell = emptyCells[random.Next(emptyCells.Count)];
            // 90% 확률로 2, 10% 확률로 4 스폰
            int newValue = random.Next(100) < 90 ? 2 : 4;
            Grid[cell.row, cell.col] = newValue;
        }

        /// <summary>
        /// 현재 보드 상태를 콘솔에 출력합니다.
        /// 각 셀은 5자리 폭으로 출력하여 정렬합니다.
        /// </summary>
        public void PrintBoard()
        {
            Console.Clear();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    // 0은 빈 칸을 의미하므로 공백으로 출력
                    Console.Write($"{(Grid[i, j] == 0 ? "." : Grid[i, j].ToString()),5}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 주어진 배열(행 또는 열)을 왼쪽으로 슬라이드 및 병합한 결과를 반환합니다.
        /// </summary>
        private int[] SlideAndCombine(int[] line)
        {
            List<int> newLine = new List<int>();
            // 0이 아닌 값만 추출
            foreach (int num in line)
            {
                if (num != 0)
                    newLine.Add(num);
            }
            // 인접한 같은 숫자 병합 (한 번 병합 후에는 다음 값은 건너뛰기)
            for (int i = 0; i < newLine.Count - 1; i++)
            {
                if (newLine[i] == newLine[i + 1])
                {
                    newLine[i] *= 2;   // 병합 후 값 2배
                    newLine[i + 1] = 0; // 중복된 값을 0으로 표시
                    i++;               // 다음 숫자는 건너뜀
                }
            }
            // 병합 후 0이 제거된 배열 생성
            List<int> finalLine = new List<int>();
            foreach (int num in newLine)
            {
                if (num != 0)
                    finalLine.Add(num);
            }
            // 남은 칸은 0으로 채워 배열 길이를 Size로 맞춤
            while (finalLine.Count < Size)
                finalLine.Add(0);

            return finalLine.ToArray();
        }

        /// <summary>
        /// 왼쪽으로 이동하는 동작을 처리합니다.
        /// 각 행을 슬라이드 및 병합한 후, 보드가 변경되었는지 여부를 반환합니다.
        /// </summary>
        public bool MoveLeft()
        {
            bool moved = false;
            for (int i = 0; i < Size; i++)
            {
                int[] row = new int[Size];
                for (int j = 0; j < Size; j++)
                    row[j] = Grid[i, j];

                int[] newRow = SlideAndCombine(row);

                for (int j = 0; j < Size; j++)
                {
                    if (Grid[i, j] != newRow[j])
                    {
                        Grid[i, j] = newRow[j];
                        moved = true;
                    }
                }
            }
            return moved;
        }

        /// <summary>
        /// 오른쪽으로 이동하는 동작을 처리합니다.
        /// 각 행을 반전하여 처리한 후 다시 반전합니다.
        /// </summary>
        public bool MoveRight()
        {
            bool moved = false;
            for (int i = 0; i < Size; i++)
            {
                int[] row = new int[Size];
                for (int j = 0; j < Size; j++)
                    row[j] = Grid[i, j];

                // 오른쪽 이동을 위해 배열을 뒤집어서 왼쪽 이동 로직 적용
                Array.Reverse(row);
                int[] newRow = SlideAndCombine(row);
                Array.Reverse(newRow);

                for (int j = 0; j < Size; j++)
                {
                    if (Grid[i, j] != newRow[j])
                    {
                        Grid[i, j] = newRow[j];
                        moved = true;
                    }
                }
            }
            return moved;
        }

        /// <summary>
        /// 위로 이동하는 동작을 처리합니다.
        /// 각 열을 슬라이드 및 병합한 후, 보드가 변경되었는지 여부를 반환합니다.
        /// </summary>
        public bool MoveUp()
        {
            bool moved = false;
            for (int j = 0; j < Size; j++)
            {
                int[] column = new int[Size];
                for (int i = 0; i < Size; i++)
                    column[i] = Grid[i, j];

                int[] newColumn = SlideAndCombine(column);
                for (int i = 0; i < Size; i++)
                {
                    if (Grid[i, j] != newColumn[i])
                    {
                        Grid[i, j] = newColumn[i];
                        moved = true;
                    }
                }
            }
            return moved;
        }

        /// <summary>
        /// 아래로 이동하는 동작을 처리합니다.
        /// 각 열을 반전하여 처리한 후 다시 반전합니다.
        /// </summary>
        public bool MoveDown()
        {
            bool moved = false;
            for (int j = 0; j < Size; j++)
            {
                int[] column = new int[Size];
                for (int i = 0; i < Size; i++)
                    column[i] = Grid[i, j];

                Array.Reverse(column);
                int[] newColumn = SlideAndCombine(column);
                Array.Reverse(newColumn);

                for (int i = 0; i < Size; i++)
                {
                    if (Grid[i, j] != newColumn[i])
                    {
                        Grid[i, j] = newColumn[i];
                        moved = true;
                    }
                }
            }
            return moved;
        }

        /// <summary>
        /// 보드에서 더 이상 이동 가능한 방법이 있는지 확인합니다.
        /// 빈 칸이 있거나 인접한 칸끼리 병합 가능한 경우 이동 가능.
        /// </summary>
        public bool CanMove()
        {
            // 빈 칸이 있으면 이동 가능
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (Grid[i, j] == 0)
                        return true;

            // 인접한 칸이 같은 값이면 병합 가능하므로 이동 가능
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    int current = Grid[i, j];
                    if (j < Size - 1 && Grid[i, j + 1] == current)
                        return true;
                    if (i < Size - 1 && Grid[i + 1, j] == current)
                        return true;
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace review_session7_SnakeGame
{

    class Snake
    {
        public List<Point> Body { get; private set; } = new List<Point>();

        public Direction CurrentDirection { get; set; } = Direction.Right;

        public Snake(int startX, int startY)
        {
            Body.Add(new Point(startX, startY));
        }


        // 머리 좌표를 얻을 수 있는 함수
        public Point GetHead()
        {
            return Body[0];
        }

        public Point Move(bool grow)
        {
            Point head = GetHead();
            Point newHead = head;

            switch (CurrentDirection)
            {
                case Direction.Up:
                    newHead = new Point(headX, headY + 1);
                    break;
                case Direction.Down:
                    newHead = new Point(headX, headY + 1);
                    break;
                case Direction.Up:
                    newHead = new Point(headX, headY + 1);
                    break;
                case Direction.Up:
                    newHead = new Point(headX, headY + 1);
                    break;
            }
        }
    }
}

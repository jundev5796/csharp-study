using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

namespace review_session7_SnakeGame
{

    class Snake
    {
        public List<Point> Body { get; private set; } = new List<Point>();

        public Direction CurrentDirection { get; set; } = Direction.Right;

        public Snake(int startX, int startY)
        {
            Body.Add(new Point(startX, startY)); //머리위치
        }

        //머리 좌표를 얻을 수 있는 함수
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
                    newHead = new Point(head.X, head.Y - 1);
                    break;
                case Direction.Down:
                    newHead = new Point(head.X, head.Y + 1);
                    break;
                case Direction.Left:
                    newHead = new Point(head.X - 1, head.Y);
                    break;
                case Direction.Right:
                    newHead = new Point(head.X + 1, head.Y);
                    break;
                default:
                    break;
            }
            //새 머리를 몸통의 맨 앞에 추가
            Body.Insert(0, newHead);

            //grow가 false면 꼬리를 제거해서 길이 유지
            if (!grow) Body.RemoveAt(Body.Count - 1);

            return newHead;
        }

        public bool Contains(Point p)
        {
            foreach (var part in Body)
            {
                if (part.X == p.X && part.Y == p.Y) return true;
            }
            return false;
        }
    }
}

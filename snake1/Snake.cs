using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake1
{
    class Snake: Figure
    {
        Direction direction;

        public Snake(point1 tail, int length, Direction direction)
        {
            pList = new List<point1>();

            for(int i = 0; i < length; i++)
            {
                point1 p = new point1(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            point1 tail = pList.First();
            pList.Remove(tail);
            point1 head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public point1 GetNextPoint()
        {
            point1 head = pList.Last();
            point1 nextPoint = new point1(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace snake1
{
    class Snake: Figure
    {

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
    }
}

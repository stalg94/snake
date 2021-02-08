using System;
using System.Collections.Generic;
using System.Text;

namespace snake1
{
    class VerticalLine: Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<point1>();
            for (int y = yUp; y <=yDown; y++)
            {
                point1 p = new point1(x, y, sym);
                pList.Add(p);
            }
        }
    }
}

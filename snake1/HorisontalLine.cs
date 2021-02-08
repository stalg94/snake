using System;
using System.Collections.Generic;
using System.Text;

namespace snake1
{
    class HorisontalLine : Figure
    {
        public HorisontalLine(int xLeft, int xRight,int y, char sym)
        {
            pList = new List<point1>();
            for(int x =xLeft; x <= xRight; x++)
            {
                point1 p = new point1(x, y, sym);
                pList.Add(p);
            }
        }
    }
}

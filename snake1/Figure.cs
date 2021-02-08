using System;
using System.Collections.Generic;
using System.Text;

namespace snake1
{
    class Figure
    {
        protected List<point1> pList;

        public void Drow()
        {
            foreach (point1 p in pList)
            {
                p.Draw();
            }
        }
    }
}

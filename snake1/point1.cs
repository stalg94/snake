﻿using System;
using System.Collections.Generic;
using System.Text;

namespace snake1
{
    class point1
    {
        public int x;
        public int y;
        public char sym;

        public point1()
        {
            Console.Write("tuleb uus märk");
        }
        public  point1(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}


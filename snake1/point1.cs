using System;
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
        }
        public  point1(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        internal void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y + offset;
            }
            else if(direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public point1(point1 p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}


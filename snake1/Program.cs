using System;
using System.Collections.Generic;
using System.Threading;

namespace snake1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            HorisontalLine upLine = new HorisontalLine(0, 78,0,'*');
            HorisontalLine downLine = new HorisontalLine(0,78,24, '*');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            point1 p = new point1(4, 5, '+');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();

            }



        }

    }

}

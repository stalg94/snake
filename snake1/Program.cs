using System;
using System.Collections.Generic;

namespace snake1
{
    class Program
    {

        static void Main(string[] args)
        {

            //point1 p1 = new point1(1, 3, '*');
            //p1.Draw();
            //point1 p2 = new point1(4, 5, '#');
            //p2.Draw();

            //List<int> num = new List<int>();
            //num.Add(0);
            //num.Add(1);
            //num.Add(2);

            //int x = num[0];
            //int y = num[1];
            //int z = num[2];

            //foreach(int i in num)
            //{
            //    Console.WriteLine(i);
            //}
            //num.RemoveAt(0);
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
            p.Draw();
        }

    }

}

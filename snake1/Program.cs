using System;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            point1 p1 = new point1(1, 3, '*');
            p1.Draw();
            point1 p2 = new point1(4,5, '#');
            p2.Draw();
            Console.ReadLine();
        }

    }

}

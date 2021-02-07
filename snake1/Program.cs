using System;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            point1 p1 = new point1(1, 3, '*');
            p1.Draw();
            point1 p2 = new point1(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);


            List<point1> pList = new List<point1>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }

    }

}

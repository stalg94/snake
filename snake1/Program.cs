using System;
using System.Collections.Generic;

namespace snake1
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            point1 p1 = new point1(1, 3, '*');
            p1.Draw();
            point1 p2 = new point1(4, 5, '#');
            p2.Draw();

            List<int> num = new List<int>();
            num.Add(0);
            num.Add(1);
            num.Add(2);

            int x = num[0];
            int y = num[1];
            int z = num[2];

            foreach(int i in num)
            {
                Console.WriteLine(i);
            }


            //HorisontalLine line = new HorisontalLine();
            //line.Draw();

            Console.ReadLine();
        }

    }

}

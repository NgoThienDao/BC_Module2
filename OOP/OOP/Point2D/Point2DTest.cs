using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Point2D
{
    class Point2DTest
    {
        static void Main()
        {
            Point2D[] points = new Point2D[2];
            points[0] = new Point2D();
            points[1] = new Point2D(2, 3);
            for(int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("(x, y) = {0}", points[i].ToString());
            }
            Console.ReadKey();
        }
    }
}

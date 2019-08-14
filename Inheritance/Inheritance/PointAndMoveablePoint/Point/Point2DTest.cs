using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.PointAndMoveablePoint.Point
{
    public class Point2DTest
    {
        public static void Main()
        {
            Point2D[] point2d = new Point2D[2];
            point2d[0] = new Point2D(1, 3);
            point2d[1] = new Point2D(5, 6);
            for (int i = 0; i < point2d.Length; i++)
            {
                Console.WriteLine("(x, y) = {0}", point2d[i].Display());
            }
            Console.ReadKey();
        }
    }
}

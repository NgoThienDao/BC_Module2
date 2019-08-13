using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Point3D
{
    class Point3DTest
    {
        static void Main()
        {
            Point3D[] points = new Point3D[2];
            points[0] = new Point3D();
            points[1] = new Point3D(1, 4, 6);
            for(int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("(x, y, z) = {0}", points[i].ToString());
            }
            Console.ReadKey();
        }
    }
}

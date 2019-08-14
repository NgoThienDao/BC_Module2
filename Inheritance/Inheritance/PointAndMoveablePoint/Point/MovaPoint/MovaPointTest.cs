using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.PointAndMoveablePoint.Point.MovaPoint
{
    public class MovaPointTest
    {
        public static void Main()
        {
            MovaPoint mova = new MovaPoint(5, 6, 1, 2);
            Console.WriteLine(mova.Display());
            mova.move();
            mova.Speed = new float[]
            {
                mova.X,
                mova.Y
            };
            Console.WriteLine(mova.Display());
            Console.ReadKey();
        }
    }
}

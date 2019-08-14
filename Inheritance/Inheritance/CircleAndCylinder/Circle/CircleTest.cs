using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.CircleAndCylinder.Circle
{
    public class CircleTest
    {
        public static void Main()
        {
            Circle[] circles = new Circle[2];
            circles[0] = new Circle();
            circles[1] = new Circle(5, "blue");
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine("Circle {0}: {1}", (i + 1), circles[i].Display());
            }
            Console.ReadKey();
        }
    }
}

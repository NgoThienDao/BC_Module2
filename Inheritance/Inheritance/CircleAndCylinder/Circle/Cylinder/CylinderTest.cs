using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.CircleAndCylinder.Circle.Cylinder
{
    public class CylinderTest
    {
        public static void Main()
        {
            Cylinder[] cylinders = new Cylinder[2];
            cylinders[0] = new Cylinder();
            cylinders[1] = new Cylinder(5, "green", 3);
            for (int j = 0; j < cylinders.Length; j++)
            {
                Console.WriteLine("Cylinder {0}: {1}", (j + 1), cylinders[j].Display());
            }
            Console.ReadKey();
        }
    }
}

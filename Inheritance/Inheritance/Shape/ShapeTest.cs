using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape
{
    public class ShapeTest
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Shape("green", false);
            shapes[1] = new Shape("red", true);
            for(int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Shape {0} has: ", (i + 1));
                Console.WriteLine(shapes[i].Display());
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Triangle.Shape.Triangle
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Triangle[] triangle = new Triangle[3];
            triangle[0] = new Triangle(1, 2, 3, "blue", false);
            triangle[1] = new Triangle();
            triangle[2] = new Triangle(3, 4, 5);
            for (int i = 0; i < triangle.Length; i++)
            {
                Console.WriteLine("Triangle {0} has: {1}", (i + 1), triangle[i].Display());
            }
            Console.ReadKey();
        }
    }
}

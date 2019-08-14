using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape.Rectangle
{
    public class RectangleTest
    {
        public static void Main()
        {
            Rectangle[] rectangles = new Rectangle[2];
            rectangles[0] = new Rectangle("green", false, 10, 20);
            rectangles[1] = new Rectangle("red", true, 5, 10);
            for(int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine("Rectangle {0} has: ", (i + 1));
                Console.WriteLine(rectangles[i].Display());
            }
            Console.ReadKey();
        }
    }
}

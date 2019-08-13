using System;
using System.Collections.Generic;
using System.Text;
using OOP.Rectangle;

namespace OOP.Rectangle
{
    class RectangleTest
    {
        static void Main()
        {
            Rectangle[] rectangles = new Rectangle[3];
            rectangles[0] = new Rectangle();
            rectangles[1] = new Rectangle(1, 3);
            rectangles[2] = new Rectangle(5, 4);
            for(int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine("Rectangle {0} has:", (i + 1));
                Console.WriteLine("Width = {0}", rectangles[i].Width);
                Console.WriteLine("Height = {0}", rectangles[i].Height);
                Console.WriteLine("Are = {0}", rectangles[i].Area());
                Console.WriteLine("Perimeter = {0}", rectangles[i].Perimeter());
            }
            Console.ReadKey();
        }
    }
}

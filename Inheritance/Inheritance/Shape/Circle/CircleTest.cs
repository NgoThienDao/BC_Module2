using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape.Circle
{
    public class CircleTest
    {
        public static void Main()
        {
            Circle circle = new Circle("blue", true, 10);
            Console.WriteLine("Circle has: ");
            Console.WriteLine(circle.Display());
            Console.ReadKey();
        }
    }
}

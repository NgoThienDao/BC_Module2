using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape.Rectangle.Square
{
    public class SquareTest
    {
        public static void Main()
        {
            Square square = new Square("yellow", true, 10);
            Console.WriteLine("Square has: ");
            Console.WriteLine(square.Display());
            Console.ReadKey();
        }
    }
}

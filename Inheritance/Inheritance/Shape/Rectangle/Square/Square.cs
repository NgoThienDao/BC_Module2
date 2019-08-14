using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape.Rectangle.Square
{
    public class Square : Rectangle
    {
        public Square(string color, bool filled, double side) : base(color, filled, side, side)
        {
            Width = side;
            Height = side;
        }

        public override string Display()
        {
            return base.Display();
        }
    }
}

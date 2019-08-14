using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape.Rectangle
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(String color, bool filled, double width, double height) : base(color, filled)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            set { width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { height = value; }
        }

        public double Area
        {
            get { return Height * Width; }
        }

        public double Perimeter
        {
            get { return (Height + Width) * 2; }
        }

        public override string Display()
        {
            return base.Display()
                + "\nWidth: " + Width
                + "\nHeight: " + Height
                + "\nPerimeter: " + Perimeter
                + "\nArea: " + Area;
        }
    }
}

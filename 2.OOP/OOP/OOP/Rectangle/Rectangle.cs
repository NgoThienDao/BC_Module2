using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Rectangle
{
    public class Rectangle
    {
        private double width = 10;
        private double height = 20;

        public Rectangle()
        {

        }

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return (Width + Height) * 2;
        }
    }
}

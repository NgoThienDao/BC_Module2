using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Triangle.Shape.Triangle
{
    public class Triangle : Shape
    {
        private double side1 = 1.0;
        private double side2 = 1.0;
        private double side3 = 1.0;

        public Triangle()
        {

        }

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public Triangle(double side1, double side2, double side3, String color, bool filled) : base(color, filled)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double Side1 { get => side1; set => side1 = value; }

        public double Side2 { get => side2; set => side2 = value; }

        public double Side3 { get => side3; set => side3 = value; }

        public double Perimeter
        {
            get { return (Side1 + Side2 + Side3); }
        }

        public double Area
        {
            get { return Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - Side1) * (Perimeter / 2 - Side2) * (Perimeter / 2 - Side3)); }
        }

        public override string Display()
        {
            return base.Display()
                + "\nSide 1: " + Side1
                + "\nSide 2: " + Side2
                + "\nSide 3: " + Side3
                + "\nPerimeter: " + Perimeter
                + "\nArea: " + Area;
        }
    }
}

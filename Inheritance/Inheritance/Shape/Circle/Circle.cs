using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape.Circle
{
    public class Circle : Shape
    {
        private double radius = 1.0;

        public Circle(String color, bool filled, double radius) : base(color, filled)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area
        {
            get { return Radius * Radius * Math.PI; }
        }

        public double Perimeter
        {
            get { return 2 * Math.PI * Radius; }
        }

        public override string Display()
        {
            return base.Display()
                + "\nRadius: " + Radius
                + "\nPerimeter: " + Perimeter + " m"
                + "\nArea: " + Area + " m^2";
        }
    }
}

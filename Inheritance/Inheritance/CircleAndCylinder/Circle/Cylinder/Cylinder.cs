using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.CircleAndCylinder.Circle.Cylinder
{
    public class Cylinder : Circle
    {
        private double height = 2.0;

        public Cylinder()
        {

        }

        public Cylinder(double radius, String color, double height) : base(radius, color)
        {
            this.height = height;
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = height; }
        }

        public new double Area
        {
            get { return base.Area * Height; }
        }

        public override string Display()
        {
            return base.Display()
                + "\nHeight: " + Height
                + "\nArea cylinder: " + Area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.CircleAndCylinder.Circle
{
    public class Circle
    {
        private double radius = 1.0;
        private String color = "red";

        public Circle()
        {

        }

        public Circle(double radius, String color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double Radius
        {
            get { return this.radius; }
            set { radius = value; }
        }

        public String Color
        {
            get { return this.color; }
            set { color = value; }
        }

        public double Area
        {
            get { return Radius * Radius * Math.PI; }
        }

        public virtual string Display()
        {
            return "\nColor: " + Color
                + "\nRadius: " + Radius
                + "\nArea circle: " + Area;
        }
    }
}

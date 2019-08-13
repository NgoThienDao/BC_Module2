using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Point2D
{
    class Point2D
    {
        private double x = 0;
        private double y = 0;

        public Point2D()
        {

        }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}

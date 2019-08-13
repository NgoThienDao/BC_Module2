using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Point3D
{
    class Point3D
    {
        private double x = 0;
        private double y = 0;
        private double z = 0;

        public Point3D()
        {

        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
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

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }
    }
}

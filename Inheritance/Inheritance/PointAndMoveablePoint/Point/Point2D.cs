using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.PointAndMoveablePoint.Point
{
    public class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;
        private float[] xy;

        public Point2D()
        {

        }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float[] XY
        {
            get { return xy; }
            set { xy = value; }
        }

        public virtual string Display()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}

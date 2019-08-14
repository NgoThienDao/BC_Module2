using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.PointAndMoveablePoint.Point.MovaPoint
{
    public class MovaPoint : Point2D
    {
        private float xSpeed = 0.0f;
        private float ySpeed = 0.0f;
        private float[] xySpeed;

        public MovaPoint()
        {

        }

        public MovaPoint(float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public MovaPoint(float xSpeed, float ySpeed, float x, float y) : base(x, y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public float XSpeed
        {
            get { return xSpeed; }
            set { xSpeed = value; }
        }

        public float YSpeed
        {
            get { return ySpeed; }
            set { ySpeed = value; }
        }

        public float[] Speed
        {
            get { return xySpeed; }
            set { xySpeed = value; }
        }


        public override string Display()
        {
            return base.Display()
                + ", speed = (" + XSpeed + ", " + YSpeed + ")";
        }

        public MovaPoint move()
        {
            X += XSpeed;
            Y += YSpeed;
            return this;
        }
    }
}

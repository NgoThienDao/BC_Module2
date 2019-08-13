using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Fan
{
    public class Fan
    {
        private const int SLOW = 1;
        private const int MEDIUM = 2;
        private const int FAST = 3;
        private int speed = 1;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public Fan()
        {

        }

        public Fan(int speed, bool on, double radius, string color)
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            if (on == true)
            {
                return "Speed = " + Speed + ", color: " + Color + ", radius = " + Radius + ", fan is on";
            }
            else
            {
                return "Color: " + Color + ", radius = " + Radius + ", fan is off";
            }
        }
    }
}

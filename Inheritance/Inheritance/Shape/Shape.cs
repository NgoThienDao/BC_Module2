using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape
{
    public class Shape
    {
        private String color;
        private bool filled;


        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        public virtual string Display()
        {
            return "Color: " + Color + ", " + (Filled ? "filled" : "not filled");
        }
    }
}

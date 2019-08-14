using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Triangle.Shape
{
    public class Shape
    {
        private String color = "red";
        private bool filled = true;

        public Shape()
        {

        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public String Color { get => color; set => color = value; }

        public bool Filled { get => filled; set => filled = value; }

        public virtual string Display()
        {
            return "\nColor: " + Color
                + " and " + (Filled ? "filled" : "not filled");
        }
    }
}

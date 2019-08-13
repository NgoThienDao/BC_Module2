using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.QuadraticEquation
{
    class QuadraticEquation
    {
        private double a = 1;
        private double b = 1;
        private double c = 1;

        public QuadraticEquation()
        {

        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double Discriminant()
        {
            return b * b - 4 * a * c;
        }

        public double Root1()
        {
            return (-b + Math.Sqrt(Discriminant())) / (2 * a);
        }

        public double Root2()
        {
            return (-b - Math.Sqrt(Discriminant())) / (2 * a);
        }
    }
}

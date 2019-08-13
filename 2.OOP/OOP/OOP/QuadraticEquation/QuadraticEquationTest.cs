using System;
using System.Collections.Generic;
using System.Text;
using OOP.QuadraticEquation;

namespace OOP.QuadraticEquation
{
    class QuadraticEquationTest
    {
        public static void Main()
        {
            QuadraticEquation[] quadraticEquations = new QuadraticEquation[3];
            quadraticEquations[0] = new QuadraticEquation();
            quadraticEquations[1] = new QuadraticEquation(1, 2, 1);
            quadraticEquations[2] = new QuadraticEquation(1, 3, 2);
            for(int i = 0; i < quadraticEquations.Length; i++)
            {
                Console.WriteLine("Quadratic Equation {0} has:", (i + 1));
                Console.WriteLine("a = {0}", quadraticEquations[i].A);
                Console.WriteLine("b = {0}", quadraticEquations[i].B);
                Console.WriteLine("c = {0}", quadraticEquations[i].C);
                if (quadraticEquations[i].Discriminant() < 0)
                {
                    Console.WriteLine("No root");
                }
                else if (quadraticEquations[i].Discriminant() == 0)
                {
                    Console.WriteLine("The equation has one root {0}", quadraticEquations[i].Root1());
                }
                else
                {
                    Console.WriteLine("The equation has two roots");
                    Console.WriteLine("x1 = {0}", quadraticEquations[i].Root1());
                    Console.WriteLine("x2 = {0}", quadraticEquations[i].Root2());
                }
            }
            Console.ReadKey();
        }
    }
}

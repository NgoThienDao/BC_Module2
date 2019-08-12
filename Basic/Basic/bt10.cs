using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt10
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter third number: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            double a = (x + y) * z;
            double b = x * y + y * z;
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y)*z is {3} and x.y+y.z is {4}", x, y, z, a, b);
            Console.ReadKey();
        }
    }
}

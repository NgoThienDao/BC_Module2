using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt9
    {
        static void Main()
        {
            Console.Write("\nEnter the First number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Four number: ");
            int d = int.Parse(Console.ReadLine());
            double Average = (a + b + c + d) / 4;
            Console.WriteLine("Expected Output:");
            Console.Write("The average of {0}, {1}, {2}, {3} is: {4}", a, b, c, d, Average);
            Console.ReadKey();
        }
    }
}

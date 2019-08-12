using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt6
    {
        static void Main()
        {
            Console.WriteLine("Test Data:");
            Console.WriteLine("Input the first number to multiply: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the three number to multiply: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output: {0}", a * b * c);
            Console.ReadKey();
        }
    }
}

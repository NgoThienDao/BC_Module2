using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt2
    {
        static void Main()
        {
            Console.WriteLine("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int Sum = a + b;
            Console.WriteLine("Sum of a and b: {0}", Sum);
            Console.ReadKey();
        }
    }
}

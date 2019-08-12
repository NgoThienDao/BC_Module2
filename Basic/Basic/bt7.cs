using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt7
    {
        static void Main()
        {
            Console.WriteLine("Input the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
            Console.WriteLine("{0} x {1} = {2}", a, b, (a * b));
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
            Console.WriteLine("{0} mod {1} = {2}", a, b, (a % b));
            Console.ReadKey();
        }
    }
}

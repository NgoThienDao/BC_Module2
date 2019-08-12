using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt20
    {
        static void Main()
        {
            Console.WriteLine("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(2 * Math.Abs(a - b));
            }
            else
            {
                Console.WriteLine(Math.Abs(a - b));
            }
            Console.ReadKey();
        }
    }
}

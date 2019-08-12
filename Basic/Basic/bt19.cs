using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt19
    {
        static void Main()
        {
            Console.WriteLine("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine(3 * (a + b));
            }
            Console.ReadKey();
        }
    }
}

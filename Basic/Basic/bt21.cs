using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt21
    {
        static void Main()
        {
            Console.WriteLine("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = int.Parse(Console.ReadLine());
            if ((a + b) == 20 || a == 20 || b == 20)
            {
                Console.WriteLine(true);
            }
            Console.ReadKey();
        }
    }
}

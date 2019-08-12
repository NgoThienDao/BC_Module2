using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt8
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, (a * i));
            }
            Console.ReadKey();
        }
    }
}

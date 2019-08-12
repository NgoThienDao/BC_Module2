using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt6
    {
        static void Main()
        {
            Console.WriteLine("Test Data : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            if (num > 0)
            {
                Console.WriteLine("The value of n = 1");
            }
            else if (num == 0)
            {
                Console.WriteLine("The value of n = 0");
            }
            else if (num < 0)
            {
                Console.WriteLine("The value of n = -1");
            }
            Console.ReadKey();
        }
    }
}

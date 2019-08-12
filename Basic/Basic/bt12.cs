using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt12
    {
        static void Main()
        {
            Console.Write("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.ReadKey();
        }
    }
}
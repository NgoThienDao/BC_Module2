using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt2
    {
        static void Main()
        {
            Console.Write("Test Data : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output : ");
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is an even integer", number);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer", number);
            }
            Console.Read();
        }
    }
}

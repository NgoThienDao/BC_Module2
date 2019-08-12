using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt3
    {
        static void Main()
        {
            Console.Write("Test Data : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output : ");
            if (number >= 0)
            {
                Console.WriteLine("{0} is a positive number", number);
            }
            else
            {
                Console.WriteLine("{0} is a negative number", number);
            }
            Console.ReadLine();
        }
    }
}

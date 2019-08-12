using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt1
    {
        static void Main()
        {
            Console.Write("Input 1st number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output :");
            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal", num1, num2);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt8
    {
        static void Main()
        {
            Console.WriteLine("Test Data : ");
            Console.Write("Input the 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2st number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3st number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output :");
            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("The 1nd Number is the greatest among three");
            }
            else if (num1 < num2 && num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("The 3nd Number is the greatest among three");
            }
            Console.ReadKey();
        }
    }
}

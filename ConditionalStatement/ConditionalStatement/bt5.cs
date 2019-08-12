using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt5
    {
        static void Main()
        {
            Console.Write("Test Data : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output : ");
            if (age >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible for casting your vote.");
            }
            Console.ReadLine();
        }
    }
}

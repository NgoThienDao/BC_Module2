using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt7
    {
        static void Main()
        {
            Console.Write("Test Data : ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            if (height < 150)
            {
                Console.WriteLine("You are Dwarf");
            }
            else if (height >= 150 && height < 170)
            {
                Console.WriteLine("You are Normal");
            }
            else if (height >= 170)
            {
                Console.WriteLine("You are Tall");
            }
            Console.ReadKey();
        }
    }
}

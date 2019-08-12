using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt22
    {
        static void Main()
        {
            Console.WriteLine("Input number: ");
            int number = int.Parse(Console.ReadLine());
            if (Math.Abs(number - 100) <= 20 || Math.Abs(number - 200) <= 20)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}

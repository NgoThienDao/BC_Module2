using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt5
    {
        static void Main()
        {
            Console.WriteLine("Input the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output : ");
            Console.WriteLine("After Swapping :");
            Console.WriteLine("First Number : {0}", b);
            Console.WriteLine("Second Number : {0}", a);
            Console.ReadKey();
        }
    }
}

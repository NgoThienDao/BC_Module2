using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt3
    {
        static void Main()
        {
            Console.WriteLine("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int Div = a / b;
            Console.WriteLine("Div of a and b: {0}", Div);
            Console.ReadKey();
        }
    }
}

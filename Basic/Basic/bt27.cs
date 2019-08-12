using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt27
    {
        static void Main()
        {
            Console.WriteLine("Input a number(integer): ");
            int number = int.Parse(Console.ReadLine());
            int hang_chuc = number / 10;
            int hang_don_vi = number % 10;
            int sum = hang_chuc + hang_don_vi;
            Console.WriteLine("Sum of the digits of the said integer: {0}", sum);
            Console.ReadKey();
        }
    }
}

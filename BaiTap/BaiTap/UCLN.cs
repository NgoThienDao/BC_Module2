using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class UCLN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            int b = int.Parse(Console.ReadLine());

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                Console.WriteLine("No greatest common factor");
            }

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine("Greatest common factor: {0}", a);
            Console.ReadKey();
        }
    }
}

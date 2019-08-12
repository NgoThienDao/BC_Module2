using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class PhuongTrinhBacNhat
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co 1 nghiem x = {0}", -b / a);
            }
            Console.ReadKey();
        }
    }
}

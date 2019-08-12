using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class KiemTraSNT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 1 so: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool check = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("{0} la so nguyen to", number);
            }
            else
            {
                Console.WriteLine("{0} khong phai so nguyen to", number);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class HienThiCacSNTNhoHon100
    {
        static bool CheckPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Display(ref int n)
        {
            int number;
            for (number = 2; number <= n; number++)
            {
                if (CheckPrime(number) == true)
                {
                    Console.Write(number + "\t");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Day so nguyen to be hon {0} la: ", n);
            Display(ref n);
            Console.ReadKey();
        }
    }
}

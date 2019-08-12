using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class _20SNTDauTien
    {
        static bool checkPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
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
            int count = 0;
            int number = 2;
            while (count < n)
            {
                if (checkPrime(number) == true)
                {
                    Console.WriteLine(number + "\t");
                    count++;
                }
                number++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} so nguyen to dau tien la: ", n);
            Display(ref n);
            Console.ReadKey();
        }
    }
}

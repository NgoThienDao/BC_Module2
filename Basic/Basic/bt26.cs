using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt26
    {
        static void Main()
        {
            Console.WriteLine("Nhap so luong snt muon tinh tong: ");
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            int count = 0;
            int number = 2;
            while (count < n)
            {
                if (CheckPrime(number))
                {
                    sum += number;
                    count++;
                }
                number++;
            }
            Console.WriteLine("Tong 500 snt dau tien la: {0}", sum);
            Console.ReadKey();
        }

        public static bool CheckPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

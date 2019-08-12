using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class TongPhanTuTrenDuongCheo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap bac cua ma tran");
            int n = int.Parse(Console.ReadLine());
            int i, j;
            int[,] array = new int[n, n];
            Console.WriteLine("Nhap phan tu cho mang: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("array[{0},{1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine("Tong phan tu tren duong cheo chinh la: {0}", sum);
            Console.ReadKey();
        }
    }
}

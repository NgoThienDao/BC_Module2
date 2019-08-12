using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class TongCot
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Nhap hang: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cot: ");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            Console.WriteLine("Nhap phan tu cho ma tran: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine("array[{0},{1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            Console.WriteLine("Nhap cot muon tinh tong: ");
            int x = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                sum += array[i, x];
            }
            Console.WriteLine("Tong cot {0}: {1}", x, sum);
            Console.ReadKey();
        }
    }
}

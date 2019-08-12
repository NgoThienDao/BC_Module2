using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class GTLNMangHaiChieu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so hang: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m];
            Console.WriteLine("Nhap phan tu cho mang: ");
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine("array[{0},{1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int max = array[0, 0];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            Console.WriteLine("Max array[{0},{1}] = {2}", n, m, max);
            Console.ReadKey();
        }
    }
}

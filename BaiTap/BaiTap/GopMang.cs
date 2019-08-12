using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class GopMang
    {
        static void Main(string[] args)
        {
            int n, m, i;
            Console.WriteLine("Nhap so phan tu cho mang 1: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Nhap phan tu cho mang 1: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Nhap so phan tu cho mang 2: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[m];
            Console.WriteLine("Nhap phan tu cho mang 2: ");
            for (i = 0; i < m; i++)
            {
                Console.WriteLine("arr2[{0}] = ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array = new int[n + m];
            Console.WriteLine("Gop mang: ");
            for (i = 0; i < n; i++)
            {
                array[i] = arr1[i];
            }

            int k = 0;

            for (i = n; i < m + n; i++)
            {
                array[i] = arr2[k++];
            }

            for (i = 0; i < m + n; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }
}

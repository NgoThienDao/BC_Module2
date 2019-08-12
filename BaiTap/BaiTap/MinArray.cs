using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class MinArray
    {
        public static int FindMinArray(ref int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cho mang:");
            int n = int.Parse(Console.ReadLine());
            int i;
            int[] array = new int[n];
            Console.WriteLine("Nhap phan tu cho mang:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Gia tri nho nhat mang: {0}", FindMinArray(ref array));
            Console.ReadKey();
        }
    }
}

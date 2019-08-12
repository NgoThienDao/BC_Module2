using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class ThemPhanTu
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Console.WriteLine("Nhap kich thuoc mang: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phan tu cho mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap phan tu can them: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri can them: ");
            int index = int.Parse(Console.ReadLine());
            for (int i = n; i >= index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index - 1] = x;
            Console.WriteLine("Mang sau khi them: ");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }
}

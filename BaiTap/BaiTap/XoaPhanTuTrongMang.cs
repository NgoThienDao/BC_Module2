using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class XoaPhanTuTrongMang
    {
        static void Main(string[] args)
        {
            int i, index, n;
            int[] array = new int[50];

            Console.WriteLine("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap phan tu cho mang: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Nhap vi tri can xoa: ");
            index = Convert.ToInt32(Console.ReadLine());

            i = 0;
            while (i != index - 1)
                i++;

            while (i < n)
            {
                array[i] = array[i + 1];
                i++;
            }
            n--;
            Console.WriteLine("In mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }
}

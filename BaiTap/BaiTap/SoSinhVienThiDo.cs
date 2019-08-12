using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class SoSinhVienThiDo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap kich thuoc cho mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Nhap diem cho sinh vien: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            Console.WriteLine("Danh sach diem: ");
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 5 && array[i] <= 10)
                {
                    count++;
                }
            }
            Console.WriteLine("So luong sinh vien thi do: {0}", count);
            Console.ReadKey();
        }
    }
}

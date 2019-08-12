using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class DemSoLanXuatHienKyTuTrongChuoi
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Nhap chuoi bat ky: ");
            String chuoi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ky tu can dem: ");
            char kytu = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == kytu)
                {
                    count++;
                }
            }
            Console.WriteLine("So lan xuat hien cua ky tu {0} trong chuoi la: {1}", kytu, count);
            Console.ReadKey();
        }
    }
}

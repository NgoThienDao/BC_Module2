using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class TinhLai
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tien gui: ");
            int tien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thang gui: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lai suat: ");
            double laisuat = double.Parse(Console.ReadLine());

            double tienlai = 0;
            for (int i = 0; i < thang; i++)
            {
                tienlai = tien * (laisuat / 100) / 12 * thang;
            }
            Console.WriteLine("Tien lai: {0}", tienlai);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class TinhSoNgayTrongThang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thang: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang co 31 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang co 30 ngay");
                    break;
                case 2:
                    Console.WriteLine("Thang co 28 hoac 29 ngay");
                    break;
            }
            Console.ReadKey();
        }
    }
}

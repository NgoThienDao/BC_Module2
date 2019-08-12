using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class SuDungToanTu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu rong: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhap chieu dai: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = width * height;
            Console.WriteLine("Rectangle has: \nWidth = {0} \nHeight = {1} \nArea = {2}", width, height, area);
            Console.ReadKey();
        }
    }
}

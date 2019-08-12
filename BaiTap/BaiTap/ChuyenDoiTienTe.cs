using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class ChuyenDoiTienTe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input USD: ");
            int usd = int.Parse(Console.ReadLine());
            int vnd = usd * 23000;
            Console.WriteLine("Convert USD to VND: {0}", vnd);
            Console.ReadKey();
        }
    }
}

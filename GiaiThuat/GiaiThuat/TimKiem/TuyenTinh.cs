using System;
using System.Collections.Generic;
using System.Text;

namespace GiaiThuat.TimKiem
{
    public class TuyenTinh
    {
        public static int[] arr;

        public static void Main()
        {
            Console.WriteLine("----- Linear Search -----");
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine());
            Input(n);
            Console.Write("Input x = ");
            int x = int.Parse(Console.ReadLine());
            Search(x);
            Console.ReadLine();
        }

        public static void Input(int n)
        {
            Random random = new Random();
            Console.WriteLine("Phan tu mang ngau nhien trong khoang 1-100");
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 100);
            }
            Show();
        }

        public static void Search(int x)
        {
            bool exist = false;
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    exist = true;
                    break;
                }
            }
            if (exist)
            {
                Console.WriteLine("Phan tu {0} tai vi tri {1}", x, i);
            }
            else
            {
                Console.WriteLine("Khong tim duoc");
            }
        }

        public static void Show()
        {
            foreach(var element in arr)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}

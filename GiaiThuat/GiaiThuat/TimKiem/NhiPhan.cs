using System;
using System.Collections.Generic;
using System.Text;

namespace GiaiThuat.TimKiem
{
    public class NhiPhan
    {
        public static int[] arr;

        public static void Main()
        {
            Console.WriteLine("----- Binary Search -----");
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine());
            Input(n);
            SortArray();
            Console.Write("Input x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("number's possition to search for: {0}", Search(x));
            Console.Read();
        }

        public static void Input(int n)
        {
            Console.WriteLine("Phan tu mang ngau nhien trong khoang 1-100");
            Random random = new Random();
            arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100);
            }
            Show();
        }

        public static int Search(int x)
        {
            int min = 0;
            int max = arr.Length - 1;
            int mid = 0;     //mid là số chính giữa của mảng
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] < x)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }

        public static void SortArray()
        {
            Console.WriteLine("Hien thi mang sap xep qua tung gia doan: ");
            Show();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(j);
                    }
                }
                Show();
            }
        }

        public static void Swap(int i)
        {
            int temp = arr[i - 1];
            arr[i - 1] = arr[i];
            arr[i] = temp;
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

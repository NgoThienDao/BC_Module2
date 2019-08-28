using System;
using System.Collections.Generic;
using System.Text;

namespace GiaiThuat.SapXep
{
    public class BubbleSort
    {
        public static int[] arr;

        public static void Main()
        {
            Console.WriteLine("----- Bubble Sort -----");
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine());
            Input(n);
            Sort();
            Console.Read();
        }

        public static void Input(int n)
        {
            Console.WriteLine("Phan tu trong mang ngau nhien tu 1-100");
            Random random = new Random();
            arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 100);
            }
        }

        public static void Sort()
        {
            Console.WriteLine("Mang sap xep trong tung giai doan: ");
            Show();
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(j);
                    }
                }
                Show();
            }
        }

        public static void Swap(int i)
        {
            int temp = arr[i + 1];
            arr[i + 1] = arr[i];
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

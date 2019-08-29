using System;
using System.Collections.Generic;
using System.Text;

namespace GiaiThuat.SapXep
{
    public class QuickSort
    {
        public static int[] arr;

        public static void Main()
        {
            Console.WriteLine("----- Quick Sort -----");
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine());
            Input(n);
            Console.WriteLine("Mang da qua sap xep");
            int left = 0;
            int right = n - 1;
            SortArr(left, right);
            Console.Read();
        }

        public static void Input(int n)
        {
            Console.WriteLine("Phan tu trong mang ngau nhien tu 1-100");
            Random random = new Random();
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 100);
            }
        }

        public static void SortArr(int left, int right)
        {
            Show();
            int a = left + (right - left) / 2;
            int b = arr[a];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (arr[i] < b)
                {
                    i++;
                }
                while (arr[j] > b)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(i, j);
                    i++;
                    j--;
                }
                if (left < j)
                {
                    SortArr(left, j);
                }
                if (right > i)
                {
                    SortArr(i, right);
                }
            }
        }

        public static void Swap(int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

        public static void Swap(int i)
        {
            int temp = arr[i + 1];
            arr[i + 1] = arr[i];
            arr[i] = temp;
        }

        public static void Show()
        {
            foreach (var element in arr)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}

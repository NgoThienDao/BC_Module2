using System;
using System.Collections.Generic;
using System.Text;

namespace GiaiThuat.SapXep
{
    public class InsertionSort
    {
        public static int[] arr;

        public static void Main()
        {
            Console.WriteLine("------ Insertion Sort ------");
            Console.Write("Input n = ");
            int n = int.Parse(Console.ReadLine());
            InputElement(n);
            SortArray();
            Console.ReadKey();
        }

        public static void InputElement(int n)
        {
            Random random = new Random();
            Console.WriteLine("Phan tu trong mang xuat hien ngau nhien tu 1 - 100");
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 100);
            }
        }

        public static void SortArray()
        {
            Console.WriteLine("Hien thi mang sap xep qua tung gia doan: ");
            Show();
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
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

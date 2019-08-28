using System;
using System.Collections.Generic;
using System.Text;

namespace GiaiThuat.SapXep
{
    public class SelectionSort
    {
        public static int[] arr;

        public static void Main()
        {
            Console.WriteLine("---------- Selection Sort ---------");
            Console.Write("Input n = ");
            int size = int.Parse(Console.ReadLine());
            InputElement(size);
            SortArray();
            Console.ReadKey();
        }

        public static void InputElement(int n)
        {
            Console.WriteLine("Cac phan tu cho mang xuat hien ngau nhien tu -50 -> 50");
            Random random = new Random();
            arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-50, 50);
            }
        }

        public static void SortArray()
        {
            Console.WriteLine("Hien thi mang sap xep qua tung buoc: ");
            Show();
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                Swap(i, min);
                Show();
            }
        }

        public static void Swap(int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
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

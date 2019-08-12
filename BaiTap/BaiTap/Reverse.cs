using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class Reverse
    {
        static void Main()
        {
            int i, j;
            Console.WriteLine("Input size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Input element: ");

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Reverse array: ");
            for (i = 0; i < array.Length; i++)
            {
                for (j = i + 1; j < array.Length; j++)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                Console.WriteLine("array[{0}]", i);
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}

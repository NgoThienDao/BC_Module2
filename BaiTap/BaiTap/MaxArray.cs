using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class MaxArray
    {
        static void Main()
        {
            int i;
            Console.WriteLine("Input size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Input element: ");

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Max of array: {0}", max);
            Console.ReadKey();
        }
    }
}

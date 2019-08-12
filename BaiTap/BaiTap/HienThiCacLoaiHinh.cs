using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class HienThiCacLoaiHinh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3.Print isosceles triangle");
            Console.WriteLine("Input choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Print the rectangle");
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 2:
                    Console.WriteLine("Print the triangle");
                    for (int i = 1; i <= 8; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine("---------------");
                    for (int i = 7; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 3:
                    Console.WriteLine("Print isosceles triangle");
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 1; j <= 6 - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= 2 * i - 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class ThietKeMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    break;
                case 2:
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    break;
                default:
                    Console.WriteLine("No choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}

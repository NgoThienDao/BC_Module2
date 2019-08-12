using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class KiemTraNamNhuan
    {
        static bool CheckLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void DisPlay(ref int year)
        {
            if (CheckLeapYear(year) == true)
            {
                Console.WriteLine("{0} is leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year", year);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Check: ");
            DisPlay(ref year);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class TimGiaTriTrongMang
    {
        static void Main(string[] args)
        {
            String[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name’s student:");
            String name = Convert.ToString(Console.ReadLine());
            bool check = false;
            int i;
            for (i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(name))
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("Not found {0} in the list", name);
            }
            else
            {
                Console.WriteLine("Found {0} at {1} in the list", name, i);
            }
            Console.ReadKey();
        }
    }
}

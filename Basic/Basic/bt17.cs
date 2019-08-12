using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt17
    {
        static void Main()
        {
            Console.Write("Input a string: ");
            string str = Convert.ToString(Console.ReadLine());
            if(str.Length >= 1)
            {
                string s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
            Console.ReadLine();
        }
    }
}

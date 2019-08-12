using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt16
    {
        static void Main()
        {
            Console.WriteLine(reverse_first_last("w3resource"));
            Console.WriteLine(reverse_first_last("Python"));
            Console.WriteLine(reverse_first_last("x"));
        }

        public static string reverse_first_last(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}

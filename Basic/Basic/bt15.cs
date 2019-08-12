using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt15
    {
        static void Main()
        {
            string str = "w3resource";
            Console.WriteLine("Sample Output:");
            Console.WriteLine(RemoveChar(str, 1));
            Console.WriteLine(RemoveChar(str, 9));
            Console.WriteLine(RemoveChar(str, 0));
            Console.ReadKey();
        }

        public static string RemoveChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}

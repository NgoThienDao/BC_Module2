using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt14
    {
        public static void Main()
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}

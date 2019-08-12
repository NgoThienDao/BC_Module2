using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class ChuyenDoiNhietDo
    {
        static double FahrenheitToCelcius(ref double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }

        static double CelciusToFahrenheit(ref double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius to fahrenheit: {0}", CelciusToFahrenheit(ref celsius));

            Console.WriteLine("Input fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit to celsius: {0}", FahrenheitToCelcius(ref fahrenheit));
            Console.ReadKey();
        }
    }
}

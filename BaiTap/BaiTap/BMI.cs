using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class BMI
    {
        static void Main(string[] args)
        {
            double bmi;
            Console.WriteLine("Input height (m): ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Input weight (kg): ");
            double weight = double.Parse(Console.ReadLine());
            bmi = weight / (height * height);
            Console.WriteLine("BMI = {0}", bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
            Console.ReadKey();
        }
    }
}

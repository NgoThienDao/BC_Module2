using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt10
    {
        static void Main()
        {
            Console.WriteLine("Input the marks obtained in Physics : ");
            int physic = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry : ");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics : ");
            int math = int.Parse(Console.ReadLine());
            int total = physic + chemistry + math;
            Console.WriteLine("Expected Output : ");
            if (physic >= 55 && chemistry >= 50 && math >= 65 && total >= 180 || math + physic >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate isn't eligible for admission.");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using OOP.Fan;

namespace OOP.Fan
{
    class FanTest
    {
        static void Main()
        {
            Fan[] fans = new Fan[2];
            fans[0] = new Fan(3, true, 10, "yellow");
            fans[1] = new Fan(2, false, 5, "blue");
            for(int i = 0; i < fans.Length; i++)
            {
                Console.WriteLine("Fan {0} has:", (i + 1));
                Console.WriteLine(fans[i].ToString());
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatement
{
    class bt9
    {
        static void Main()
        {
            Console.Write("Input the value for X coordinate : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output :");
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant.", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quadrant.", x, y);
            }
            Console.ReadKey();
        }
    }
}

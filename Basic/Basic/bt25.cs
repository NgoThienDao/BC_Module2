﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bt25
    {
        static void Main()
        {
            for(int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}

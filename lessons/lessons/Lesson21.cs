﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson21
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;  
                }
                Console.WriteLine(i);
            }
        }
    }
}

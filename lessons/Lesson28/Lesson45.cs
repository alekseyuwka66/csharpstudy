﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson45
    {
        static void Foo(in int value)
        {
            Console.WriteLine(value);
            //value = 0;
        }
        static void Main(string[] args)
        {
            int a = 1;
            Foo(a); //in указывать не нужно
        }
    }
}

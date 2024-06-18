using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson49
    {
        static void foo(int i)
        {
            Console.WriteLine(i);
            if (i >= 3)
            {
                return;
            } 
            i++;
            foo(i);
        }
        static void Main(string[] args)
        {
            foo(0);
        }
    }
}

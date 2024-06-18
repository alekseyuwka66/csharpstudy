using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson_47
    {
        static int Sum(int a, int b, bool en = false)
        {
            int result = a + b;
            if (en)
            {
                Console.WriteLine(a + "," + b);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = 2; int b = 4;
            Sum(a, b);
        }
    }
}

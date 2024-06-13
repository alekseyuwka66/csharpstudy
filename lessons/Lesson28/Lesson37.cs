using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson37
    {
        static int r = 20;
        int c = 10;
        static int Foo()
        {
            int b = 0;
            return b;
            
        }
        static void Main(string[] args)
        {
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                i++;
                a++;
            }
            Lesson37 s = new Lesson37();
            s.c++;
            
            Console.WriteLine(s.c);
            Console.WriteLine(r);
            //i++
            //b

        }
    }
}

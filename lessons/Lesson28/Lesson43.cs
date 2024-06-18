using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson43
    {
        class myclass
        {
            public int a;
            double b;
        }
        static void Foo(myclass myclass)
        {
            myclass.a = -5;
        }
        static void Bar(ref int[] myArray)
        {
            
            myArray = null;
        }
        static void Main(string[] args)
        {
            myclass myclass = new myclass();
            int a = 2;
            Foo(myclass);
            Console.WriteLine(a);
            int[] myArray = { 1, 5, 6 };
            Bar(ref myArray);

        }
    }
}

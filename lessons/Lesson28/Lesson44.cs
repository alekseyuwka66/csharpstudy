using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson44
    {
        static void Bar(out int value)
        {
            value = 5; 
            Console.WriteLine(value);
        }
        static void Foo(ref int value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 0;
            Foo(ref a);

            int b;
            Bar(out b);

            Bar(out int c);

            //Foo(ref int s)

            string str = Console.ReadLine();
            int.TryParse(str, out int result);
            Console.WriteLine(result);  

        }
    }
}

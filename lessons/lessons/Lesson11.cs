using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson11
    {
        static void Main(string[] args)
        {
            int a = 0;
            a++; //инкремента
            Console.WriteLine(a);

            int b = 0;
            b--; //декремента
            Console.WriteLine(b);

            int c = 3;
            c = ++c * c;
            Console.WriteLine(c);
        }
    }
}

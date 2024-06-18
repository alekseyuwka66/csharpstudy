using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson46
    {
        static int Sum(string msg, params int[] a)
        {
           int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum("test"/*5, 10*/);
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson36
    {
        static void Main(string[] args)
        {
            Console.Write(sum(2, 5));
        }
        static int sum(int a, int b)
        {
            return a+ b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int sum (int a, int b, int c)
        {
            return a + b + c;
        }
        static double sum(double a, double b)
        {
            return a + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson19
    {
        static void Main(string[] args)
        {
            //for (; ; )
            //{
            //    Console.WriteLine("2");
            //    System.Threading.Thread.Sleep(300);
            //    break;
            //}
            //Console.Read();

            //int i = 0;
            //for (; i < 3; i++)
            //{
            //    Console.WriteLine(i + " 1");
            //}
            //for (; i < 5; i++)
            //{
            //    Console.WriteLine(i + " 2");
            //}

            //for (i = 0; i < 5;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int f = 0, j = 5; f < 10 && j < 12; f++, j++)
            //{
            //    Console.WriteLine("j: " + j);
            //    Console.WriteLine("i: " + i);
            //}

            int g = Convert.ToInt32(Console.ReadLine());
            for (; g >= 0; g--)
            {
                Console.WriteLine(g);
            }

        }
    }
}

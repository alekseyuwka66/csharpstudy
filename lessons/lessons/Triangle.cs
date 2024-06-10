using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Threeangle
    {
        static void Main(string[] args)
        {
            
            for (int i = 0, k = 0; i < 10; i++)
            {
                k++;
                for (int j = 0; j < k; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            for (int i = 10, f = 10; i > 0; i--)
            {
                
                for (int j = 0; j < f; j++)
                {
                    Console.Write("#");
                }
                f--;
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            for (int i = 0, f = 9, s = 0; i < 10; i++)
            {
                s++;
                for (int j = 0; j < f; j++)
                {
                    Console.Write(" ");
                }
                for (int d = 0; d < s; d++)
                {
                    Console.Write("#");
                }
                f--;
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            for (int i = 0, h = 0, l = 10; i < 10; i++)
            {
                for (int q = 0; q < h; q++)
                {
                    Console.Write(" ");
                }
                h++;
                for (int w = 0; w < l; w++)
                {
                    Console.Write("#");
                }
                l--;
                Console.WriteLine();
            }

        }
    }
}

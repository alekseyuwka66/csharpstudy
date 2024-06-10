using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson22
    {
        static void Main(string[] args)
        {
            
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine(i);
                    for (int j = 0; j <= 5; j++)
                    {
                    Console.WriteLine(j);
                    }
                }
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
               
            

        }
    }
}

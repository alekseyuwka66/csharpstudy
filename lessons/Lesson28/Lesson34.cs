using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson34
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[4,3,5];
            myArray[0, 2, 3] = 44;
            Console.ReadLine();

            int[,,] myArray1 =
            {
                {{ 2,4,5} },
                {{ 2,4,634} },
                {{3,3,5} },
            };
            
            Random rand = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int g = 0; g < myArray.GetLength(2); g++)
                    {
                        myArray[i, j, g] = rand.Next(100);  
                    }
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page" + (i + 1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int g = 0; g < myArray.GetLength(2); g++)
                    {
                        Console.Write(myArray[i,j,g] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("==============");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson32
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 6];
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100);
                }
            }
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write("\t" + myArray[y, x]);
                }
                Console.WriteLine();
            }

            int[,] myArray2 = new int[2, 3];
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int y = 0; y < myArray2.GetLength(0); y++)
            {
                for (int x = 0; x < myArray2.GetLength(1); x++)
                {
                    Console.Write("\t" + myArray2[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}

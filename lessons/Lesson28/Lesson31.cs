using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson31
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,] { { 2, 4, 5 },{ 22, 5, 7 }};
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + myArray.Rank); // возвращет какое мерности массивл

            myArray.GetLength(0); //возвращает 0 - кол-во строк 1 - колво столбцов
                                  //(кол-во элементов в каждом измерении)

            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(" " + myArray[y,x]);
                }
                Console.WriteLine();
            }
        }
    }
}

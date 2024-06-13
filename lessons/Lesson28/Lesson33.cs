using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson33
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];
            int[,] myArray1 = new int[10, 5];
            int myArrayRank = myArray.Rank;
            int myArray1Rank = myArray1.Rank;
            int myArrayLength = myArray.Length;
            int myArray1Length = myArray1.Length;

            myArray[0] = new int[5];
            myArray[1] = new int[3];
            myArray[2] = new int[10];
            
            myArray[0][3] = 55;
            int[] arr = myArray[0];

            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rand.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

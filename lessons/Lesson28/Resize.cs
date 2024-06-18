using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Resize
    {
        static void Resizes<T>(ref T[] Array, ref int kolvo)
        {
            T[] newArray = new T[kolvo];
            for (int i = 0; i < Array.Length && i < newArray.Length; i++)
            {
                newArray[i] = Array[i];
            }
            Array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2 };
            int kolv = 2;
            Resizes(ref myArray, ref kolv);

            Console.WriteLine(myArray.Length);
        }
        //Array.Resize(ref myArray, 10)
    }
}

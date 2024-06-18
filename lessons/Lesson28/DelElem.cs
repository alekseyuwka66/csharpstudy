using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class DelElem
    {
        //static void Removers(ref int[] array, int index)
        //{
        //    int[] newArray = new int[array.Length];
        //    for (int i = 0; i < index; i++)
        //    {
        //        newArray[i] = array[i];
        //    }
        //    for (int i = index; i < array.Length-1; i++)
        //    {
        //        newArray[i + 1] = array[i+1];
        //    }
        //    array = newArray;
        //}

        static void Remove(ref int[]array, int index)
        {
            int[]newArray = new int[array.Length-1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i]; //array - берем след элемент, в newarray остаемся на index удаленного элема 
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 5, 6 };
            int index = 2;
            Remove(ref myArray, index);
            Console.WriteLine(myArray[index]);

            }
    }
}

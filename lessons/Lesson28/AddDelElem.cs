using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class AddDelElem
    {
        //static void Elem(ref int[] array, int index, int newelem)
        //{
        //    for (int i = 0; i <= index && index <= array.Length - 1; i++)
        //    {
        //        if (i == index)
        //        {
        //            array[i] = newelem;
        //        }
        //    }
        //}
        static void Elems(ref int[] array, int index, int newelem)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = newelem;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2 , 3};
            int newelem = 5;
            int index = 2;
            Elems(ref myArray, index, newelem);
            Console.WriteLine(myArray[index]);

        }
    }
}

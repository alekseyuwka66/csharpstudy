using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson24
    {
        static void Main(string[] args)
        {
            int[] myArray;
            myArray = new int [5]; //выделение памяти для массива;
            myArray[1] = 3;
            myArray[0] = 10;
            int a = myArray[0];
            Console.WriteLine(myArray.Length);
            Console.WriteLine(a);
            Console.WriteLine(myArray[1]);
        }
    }
}

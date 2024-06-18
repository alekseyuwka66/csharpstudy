using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson42
    {
        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3 };
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine(myArray?.Sum() ?? 0);

        }
    }
}

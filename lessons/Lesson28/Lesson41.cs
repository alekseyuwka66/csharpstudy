using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson41
    {
        static int[] GetArray()
        {
            return null;
        }
        static void Main(string[] args)
        {
            string str = null;
            string result = str ??= "default string";
            Console.WriteLine("kolvo simbols" + result.Length);

            int[] myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine(myArray.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class RekursiaSumElems
    {
        static void Sum(int[] Array, int i = 0, int result = 0)
        {
            if (i == Array.Length)
            { 
                Console.WriteLine(result);
                return;
            }
            result += Array[i];
            i++;
            Sum(Array, i, result);
        }
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            Sum(ints);
            
        }
    }
}

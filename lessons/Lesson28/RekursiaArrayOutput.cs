using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class RekursiaArrayOutput
    {
        static void Output(int[] Array, int i = 0)
        {
            
            Console.WriteLine(Array[i]);
            if (Array.Length - 1 == i )
            {
                return;
            }
            i++;
            Output(Array, i);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 3 };
            Output(arr);
        }
    }
}

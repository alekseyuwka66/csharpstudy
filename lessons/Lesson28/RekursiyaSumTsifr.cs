using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class RekursiyaSumTsifr
    {
        static int Sum(int Value)
        {
            if (Value < 10)
                return Value;
            int digit = Value % 10;
            int nextValue = Value / 10;
            return digit + Sum(nextValue);
        }
        static void Main(string[] args)
        {
            Sum(42);
        }
    }
}

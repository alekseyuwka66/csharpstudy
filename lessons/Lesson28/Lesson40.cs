using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson40
    {

        static void Main(string[] args)
        {
            string str = null;
            string result;
            if (str == null)
            {
                result = "net dannih";
            }
            else
            {
                result = str;
            }
            Console.WriteLine(result);

            Console.WriteLine(str ?? "net dannih");

            string str1 = null;
            string result1 = str1 ?? string.Empty;
            Console.WriteLine(result.Length);

            int[] arr = { 2, 5, 6 }
            ref int b = ref arr[0]; //ccылочные локальные переменные
            b = -5;

            ref int c = ref BRR(arr); //возвращаемое ссылочное значение
            c = -5;

        }
        static ref int BRR(int[] numbers)
        {
            return ref numbers[0];
        }
    }
}

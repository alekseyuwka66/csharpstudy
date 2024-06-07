using System;
using System.Globalization;

namespace lessons
{
    internal class Lesson6
    {
        static void Main(string[] args)
        {
            string str = "5";
            string str2 = "2";
            Console.WriteLine(str + str2);

            string str3 = "3";
            int a = Convert.ToInt32(str3);

            string str4 = "4.1";
            double s = Convert.ToDouble(str4);

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            
        }
    }
}

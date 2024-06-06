using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson7
    {
        static void Main(string[] args)
        {
            string str = "2,2";
            double a = double.Parse(str);

            string str1 = "2.1";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
            };
            double b = double.Parse(str1, numberFormatInfo);

            //string str3 = "2,1asd";
            //double c = double.Parse(str3);

            string str4 = "2";
            int d;
            bool result = int.TryParse(str4, out d); //инициализируется и возвращается (d)
            if (result)
            {
                Console.WriteLine("успешно " + d);
            }
            else
            {
                Console.WriteLine("не удалось");
            }
            double j = 0;
            Console.WriteLine(4.4 + j);

            
        }
    }
}

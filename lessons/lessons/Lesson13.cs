using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson13
    {
        static void Main(string[] args)
        {
            bool isInfected = true;

            if (isInfected)
            {
                Console.WriteLine("Персонаж болен");
            }
            else
            {
                Console.WriteLine("Персонаж здоров");
            }

            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("a = 5");
            }
            else
            {
                Console.WriteLine("a != 5");
            }

            //Проверить на четность введенное число

            int d = Convert.ToInt32(Console.ReadLine());

            if ((d % 2) == 0)
            {
                Console.WriteLine("Chetnoe");
            }
            else
            {
                Console.WriteLine("Ne Chetnoe");
            }
        }
    }
}

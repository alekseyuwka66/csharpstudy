using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson16
    {
        static void Main(string[] args)
        {
            int count = 0;
            int lim = Convert.ToInt32(Console.ReadLine());
            while (count < lim)
            {
                count++;
                Console.WriteLine(count);
            }

            int fstval, sndval, count1, dopval, sum1, sum2, count2; ;
            count1 = 0;
            count2 = 0;
            sum2 = 0;
            sum1 = 0;
            Console.WriteLine("Vvedite 1oe znachenie");
            fstval = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite 2oe znachenie");
            sndval = Convert.ToInt32(Console.ReadLine());
            dopval = ++fstval;
            while (dopval < sndval)
            {
                if ((dopval % 2) == 0)
                {
                    count1++;
                    sum1 += dopval;
                }
                else
                {
                    count2++;
                    sum2 += dopval;
                }
                dopval++;
            }
            Console.WriteLine("Colvo Chet " + count1);
            Console.WriteLine("Summa " + sum1);
            Console.WriteLine("Colvo ne chet " + count2);
            Console.WriteLine("Summa " + sum2);
        }
    }
}

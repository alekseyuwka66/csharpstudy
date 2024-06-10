using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson26
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 5, 10 };
            Console.WriteLine(myArray[0]);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //заполнить массив с клавиатуры

            //int[] myArray1 = new int[5];
            //for (int i = 0;i < myArray1.Length; i++)
            //{
            //    myArray1[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(myArray1[i]);
            //}

            //вывести массив в обратном порядке

            int[] myArray2 = { 2, 3, 4, 5 };
            for (int i = myArray2.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray2[i]);
            }

            //найти сумму четных чисел в массиве
            int sum = 0;
            int[] myArray3 = { 2, 3, 4, 5, 6};
            for (int i = 0; i < myArray3.Length; i++)
            {
                if (myArray3[i] % 2 == 0)
                {
                    sum += myArray3[i];
                }
            }
            Console.WriteLine(sum);

            //найти наименьшее число в массиве
            
            int[] myArray4 = { 4, 2, 1, 2, 6};
            int less = myArray4[0];
            for (int i = 0;i < myArray4.Length; i++)
            {
               
                if (less >= myArray4[i])
                {
                    less = myArray4[i];
                }
            }
            Console.WriteLine(less);
        }
    }
}

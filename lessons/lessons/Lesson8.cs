using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson8
    {
        static void Main(string[] args)
        {
            int a = 10; 
            int b = 3;
            double c = 6;

            int result = a + b;
            Console.WriteLine(result);

            double result1 = a / b;
            Console.WriteLine(result1); // выведет 0 т.к. операнды a & b - int, result1 округляется

            double result2 = a / c;
            Console.WriteLine(result2); //если одна из операнд double, выведет значение

            double result3 = (double) a / b; //операция приведения
            Console.WriteLine(result3);

            int result4 = a % b;
            Console.WriteLine(result4); //10/3, остаток 1

            int result5 = a + b + (int) c;
            Console.WriteLine(result5);

            /*Домашнее задание
             * 1. Напишите программу, вычисляющее среднее арифмиетическое двух чисел.
            */

            double frstval = Convert.ToDouble(Console.ReadLine());
            double scndval = Convert.ToDouble(Console.ReadLine());
            double result6 = (frstval + scndval) / 2;
            Console.WriteLine(result6);

            //Введите три числа и выведите их на экран значение суммы и произведения этих чисел

            double frstval1 = Convert.ToDouble(Console.ReadLine());
            double scndval1 = Convert.ToDouble(Console.ReadLine());   
            double thrdval1 = Convert.ToDouble(Console.ReadLine());

            double sumresult7 = (frstval1 + scndval1 + thrdval1);
            double multresult8 = (frstval1 * scndval1 * thrdval1);

            Console.WriteLine(sumresult7);
            Console.WriteLine(multresult8);

            //Конвертор валют. Валюты статичны.

            double rub = Convert.ToDouble(Console.ReadLine());
            double usd = Convert.ToDouble(Console.ReadLine());

            double rubtodol = 100;
            double usdtorub = 0.01;

            double result9 = usd * rubtodol;
            double result10 = rub * usdtorub;

            Console.WriteLine(result10);
            Console.WriteLine(result9);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class calculatorifelse
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b;
                string c;
                try
                {
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не корректные значения ");
                    Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine("Выберите операцию + - * /");
                c = Console.ReadLine();

                if (c == "+")
                {
                    Console.WriteLine("Сумма равна - " + (a + b));
                }
                else if (c == "-")
                {
                    Console.WriteLine("Разность равна - " + (a - b));
                }
                else if (c == "*")
                {
                    Console.WriteLine("Произведение равно - " + (a * b));
                }
                else if (c == "/")
                {
                    Console.WriteLine("Частное равно - " + (a / b));
                }
                else
                {
                    Console.WriteLine("Введен не верный знак");
                }
                Console.ReadLine();
            }
        }
    }
}

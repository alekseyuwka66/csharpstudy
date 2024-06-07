using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lessons
{
    internal class calculatorswitch
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
                    Console.WriteLine("Введено не верное значение");
                    Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine("Выберите операцию + - * /");
                c = Console.ReadLine();

                switch (c)
                {
                    case ("+"):
                        Console.WriteLine("Сумма равна - " + (a + b));
                        break;
                    case ("-"):
                        Console.WriteLine("Разность равна - " + (a - b));
                        break;
                    case ("*"):
                        Console.WriteLine("Произведение равно - " + (a * b));
                        break;
                    case ("/"):
                        Console.WriteLine("Частное равно - " + (a / b));
                        break;
                    default:
                        Console.WriteLine("Введен не верный знак");
                        break;
                }
            
            }
        }
    }
}

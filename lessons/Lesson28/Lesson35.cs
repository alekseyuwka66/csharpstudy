
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonsnet
{
    internal class Lesson35
    {
        static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }

        static void PrintLine()
        {
            Console.WriteLine("Метод Принтлайн");
        }
        static int sum(int val1, int val2)
        {
            int result = val1 + val2;
            return result;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = sum(a, b);
            PrintResult(c);

            PrintLine();
            //dz1
            string Chars = Console.ReadLine();
            int Colvo = Convert.ToInt32(Console.ReadLine());
            StringOut(Chars,Colvo);
            //dz2
            int res;
            int[] myArray = { 2, 5, 21, 5, 436, 1, 643, 2, 1 };
            Console.WriteLine("Viberete chislo");
            int value = Convert.ToInt32(Console.ReadLine());
            res = ValueFinderOfIndex(myArray, value);
            Console.WriteLine(res);
        }
        //dz vivod stroki
        static void StringOut(string Symbols, int SymbolsCounter)
        {
            for (int i = 0; i < SymbolsCounter; i++)
            {
                Console.WriteLine(Symbols);
            }
        }
        //dz poisk indeksa elementa
        static int ValueFinderOfIndex(int[] Array, int result)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] == result)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

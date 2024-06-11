using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson28
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 42, 4, 654, 2, 435, 12 };
            Console.WriteLine(myArray[^1]); //получаем элементы с конца (с начала с 0, с конца с 1)
            Console.WriteLine(myArray[^2]);
            Index myIndex = ^4; //такая же структура как и int double str и  т.д.
            Console.WriteLine(myArray[myIndex]);
            Console.WriteLine($" {myIndex.Value} {myIndex.IsFromEnd}");
            Index myIndex1 = new Index(3, true);


            Range myRange = 1..4;
            int[] myArray2 = myArray[1..4]; // [с_какого_начинаем(входит)..каким_ограничиваемся(невыходит)]
            //для начала/конца можно не писать [..4] (0,1,2,3)
            int[] myArray3 = myArray[myRange];
            Range myRange1 = ^4..^1;


            string str = "Hello World xD :)))";
            Console.WriteLine(str[^4..^2]);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson25
    {
        static void Main(string[] args)
        {
            //варианты записи

            int[] myArray;
            myArray = new int[5];

            int[] myArray2 = new int[5];

            int[] myArray3 = new int[5] { 1, 2, 3, 5, 6 }; //инициализация элементов массива

            int[] myArray4 = new int[] { 1,2, 3, 4, 5, 6, 2, 5 }; //подсчитывает кол-во элементов самостоятельно, смотря сколько указали

            //int[] myArray5 = new int[]; так нельзя, т.к. не указываем кол-во элементов конкретным значением, или ручным способом через элементы

            int[] myArray5 = new[] { 1, 2, 3, 4 }; // указываем тип элементов через элементы

            //int[] myArray6 = new [2]; //нет ни указателя на тип элементов, ни самих элементов

            int[] myArray6 = { 1, 2, 3, };

            int[] myArray7 = Enumerable.Repeat(5,10).ToArray(); //заполнение массива (.Repeat(какой_элемент,кол-во_элементов)

            int[] myArray8 = Enumerable.Range(4,5).ToArray(); //заполнение массива (.Range(с_какокого_элемента++_начинать_запонять, кол-во_элементов)
                                                              //[4, 5, 6, 7, 8]
        }



    }
}

namespace Lessonsnet
{
    internal class Lesson30
    {
        static void Main(string[] args)
        {
            //тип_данных [,] = название_массива;
            int[,] myArray = new int[3,5];
            myArray[0,2] = 1;
            Console.WriteLine(myArray[0,2]);

            int[,] myArray1 = new int[3, 5]
            {
                { 2,5,3,6,7},
                {76,7,73,3,3 },
                {12,45643,34,7,4}
            };

            int[,] myArray2 = new int[,]
            {
                { 2,5,3,6,7},
                {76,7,73,3,3 },
                {12,45643,34,7,4},
                {2,534,2,6,3, }
            };
        }
    }
}

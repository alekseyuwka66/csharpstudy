using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson14
    {
        static void Main(string[] args)
        {
            bool isInfected = false;
            if (!isInfected)
            {
                Console.WriteLine("Здоровый");
            }

            int fanSpeed = 2000;
            bool HighTemperatue, NoCooling;
            HighTemperatue = false;
            NoCooling = fanSpeed <= 0;
            if (!HighTemperatue &&/*||*/ !NoCooling)
            {
                Console.WriteLine("пк не впорядке");
            }
            else
            {
                Console.WriteLine("пк впорядке");
            }

            if (hightemperature() | coolingstat())
            {
                Console.WriteLine("поврежден");
            }
            
        }
        public static bool hightemperature()
        {
            return true;
        }
        public static bool coolingstat()
        {
            return true;
        }
    }
}

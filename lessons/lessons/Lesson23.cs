using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Lesson23
    {
        static void Main(string[] args)
        {
            bool allowed;
            string storpass = "qwerty";
            string entpass = Console.ReadLine();
            allowed = storpass == entpass ? true : false;
            Console.WriteLine(allowed);

            int inpdat = Convert.ToInt32(Console.ReadLine());
            int otpdat = inpdat < 0 ? 1 : inpdat;
            Console.WriteLine(otpdat);
        }
    }
}

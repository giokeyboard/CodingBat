using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string of even length, return a string made of the middle two chars,
             * so the string "string" yields "ri". The string length will be at least 2.
             *
             * middleTwo("string") → "ri"
             * middleTwo("code") → "od"
             * middleTwo("Practice") → "ct"
             */
            Console.WriteLine(middleTwo("string"));
            Console.WriteLine(middleTwo("code"));
            Console.WriteLine(middleTwo("Practice"));
        }

        private static string middleTwo(string str)
        {
            return str.Substring(str.Length / 2 - 1, 2);
        }
    }
}

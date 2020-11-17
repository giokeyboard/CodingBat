using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middleThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and".
             * The string length will be at least 3.
             *
             * middleThree("Candy") → "and"
             * middleThree("and") → "and"
             * middleThree("solving") → "lvi"
             */
            Console.WriteLine(MiddleThree("Candy"));
            Console.WriteLine(MiddleThree("and"));
            Console.WriteLine(MiddleThree("solving"));
        }

        private static string MiddleThree(string str)
        {
            return str.Substring(str.Length / 2 - 1, 3);
        }
    }
}

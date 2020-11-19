using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given three ints, a b c, return true if two or more of them have the same rightmost digit.
             * The ints are non-negative. Note: the % "mod" operator computes the remainder, e.g. 17 % 10 is 7.
             *
             * lastDigit(23, 19, 13) → true
             * lastDigit(23, 19, 12) → false
             * lastDigit(23, 19, 3) → true
             */
            Console.WriteLine(LastDigit(23, 19, 13));
            Console.WriteLine(LastDigit(23, 19, 12));
            Console.WriteLine(LastDigit(23, 19, 3));
        }

        private static bool LastDigit(int a, int b, int c)
        {
            return a % 10 == b % 10 || a % 10 == c % 10 || b % 10 == c % 10;
        }
    }
}

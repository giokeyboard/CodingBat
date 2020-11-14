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
             * Given two non-negative int values, return true if they have the same last digit,
             * such as with 27 and 57. Note that the % "mod" operator computes remainders, so 17 % 10 is 7.
             *
             * lastDigit(7, 17) → true
             * lastDigit(6, 17) → false
             * lastDigit(3, 113) → true
             */
            Console.WriteLine(LastDigit(7, 17));
            Console.WriteLine(LastDigit(6, 17));
            Console.WriteLine(LastDigit(3, 113));
        }

        private static bool LastDigit(int a, int b)
        {
            return a % 10 == b % 10;
        }
    }
}

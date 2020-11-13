using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int values, return true if one is negative and one is positive.
             * Except if the parameter "negative" is true, then return true only if both are negative.
             *
             * posNeg(1, -1, false) → true
             * posNeg(-1, 1, false) → true
             * posNeg(-4, -5, true) → true
             */
            Console.WriteLine(posNeg(1, -1, false));
            Console.WriteLine(posNeg(-1, 1, false));
            Console.WriteLine(posNeg(-4, -5, true));
        }

        private static bool posNeg(int a, int b, bool negative)
        {
            return (!negative) ? a * b < 0 : a + b < 0;
        }
    }
}

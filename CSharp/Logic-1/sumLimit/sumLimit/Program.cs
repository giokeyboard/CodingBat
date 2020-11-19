using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 non-negative ints, a and b, return their sum, so long as the sum has the same number of digits as a.
             * If the sum has more digits than a, just return a without b.
             * (Note: one way to compute the number of digits of a non-negative int n is
             * to convert it to a string with String.valueOf(n) and then check the length of the string.)
             *
             * sumLimit(2, 3) → 5
             * sumLimit(8, 3) → 8
             * sumLimit(8, 1) → 9
             */
            Console.WriteLine(SumLimit(2, 3));
            Console.WriteLine(SumLimit(8, 3));
            Console.WriteLine(SumLimit(8, 1));
        }

        private static int SumLimit(int a, int b)
        {
            return (Convert.ToString(a + b).Length == Convert.ToString(a).Length) ? a + b : a;
        }
    }
}

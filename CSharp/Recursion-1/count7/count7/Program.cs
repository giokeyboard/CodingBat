using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-negative int n, return the count of the occurrences of 7 as a digit,
             * so for example 717 yields 2. (no loops).
             * Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6),
             * while divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
             *
             * count7(717) → 2
             * count7(7) → 1
             * count7(123) → 0
             */
            Console.WriteLine(Count7(717));
            Console.WriteLine(Count7(7));
            Console.WriteLine(Count7(123));
        }

        private static int Count7(int n)
        {
            if (n == 0) return 0;
            if (n % 10 == 7) return 1 + Count7(n / 10);
            return Count7(n / 10);
        }
    }
}

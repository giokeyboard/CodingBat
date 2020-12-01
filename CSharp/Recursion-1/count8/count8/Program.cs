using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-negative int n, compute recursively (no loops) the count of the occurrences of 8 as a digit,
             * except that an 8 with another 8 immediately to its left counts double, so 8818 yields 4.
             * Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6),
             * while divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
             *
             * count8(8) → 1
             * count8(818) → 2
             * count8(8818) → 4
             */
            Console.WriteLine(Count8(8));
            Console.WriteLine(Count8(818));
            Console.WriteLine(Count8(8818));

        }

        private static int Count8(int n)
        {
            if (n == 0) return 0;
            if (n % 10 == 8)
            {
                if ((n / 10) % 10 == 8) return 2 + Count8(n / 10);
                return 1 + Count8(n / 10);
            }
            return Count8(n / 10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-negative int n, return the sum of its digits recursively (no loops).
             * Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6),
             * while divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
             *
             * sumDigits(126) → 9
             * sumDigits(49) → 13
             * sumDigits(12) → 3
             */
            Console.WriteLine(SumDigits(126));
            Console.WriteLine(SumDigits(49));
            Console.WriteLine(SumDigits(12));
        }

        private static int SumDigits(int n)
        {
            if (n < 10) return n;
            return n % 10 + SumDigits(n / 10);
        }
    }
}

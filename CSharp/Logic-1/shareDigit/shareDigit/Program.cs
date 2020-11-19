using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shareDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two ints, each in the range 10..99,
             * return true if there is a digit that appears in both numbers, such as the 2 in 12 and 23.
             * (Note: division, e.g. n/10, gives the left digit while the % "mod" n%10 gives the right digit.)
             *
             * shareDigit(12, 23) → true
             * shareDigit(12, 43) → false
             * shareDigit(12, 44) → false
             */
            Console.WriteLine(ShareDigit(12, 23));
            Console.WriteLine(ShareDigit(12, 43));
            Console.WriteLine(ShareDigit(12, 44));
        }

        private static bool ShareDigit(int a, int b)
        {
            return a / 10 == b / 10 || a / 10 == b % 10 || a % 10 == b / 10 || a % 10 == b % 10;
        }
    }
}

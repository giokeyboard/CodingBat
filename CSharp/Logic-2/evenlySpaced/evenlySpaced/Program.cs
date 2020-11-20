using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenlySpaced
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given three ints, a b c, one of them is small, one is medium and one is large.
             * Return true if the three values are evenly spaced, so the difference between small and
             * medium is the same as the difference between medium and large.
             *
             * evenlySpaced(2, 4, 6) → true
             * evenlySpaced(4, 6, 2) → true
             * evenlySpaced(4, 6, 3) → false
             */
            Console.WriteLine(EvenlySpaced(2, 4, 6));
            Console.WriteLine(EvenlySpaced(4, 6, 2));
            Console.WriteLine(EvenlySpaced(4, 6, 3));
        }

        private static bool EvenlySpaced(int a, int b, int c)
        {
            return a + b == 2 * c || a + c == 2 * b || b + c == 2 * a;
        }
    }
}

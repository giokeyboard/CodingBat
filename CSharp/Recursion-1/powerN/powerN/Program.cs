using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerN
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given base and n that are both 1 or more, compute recursively (no loops) the value of
             * base to the n power, so powerN(3, 2) is 9 (3 squared).
             *
             * powerN(3, 1) → 3
             * powerN(3, 2) → 9
             * powerN(3, 3) → 27
             */
            Console.WriteLine(PowerN(3, 1));
            Console.WriteLine(PowerN(3, 2));
            Console.WriteLine(PowerN(3, 3));
        }

        private static int PowerN(int @base, int n)
        {
            if (n == 1) return @base;
            return @base * (PowerN(@base, n - 1));
        }
    }
}

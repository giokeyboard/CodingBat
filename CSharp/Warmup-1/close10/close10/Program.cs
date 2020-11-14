using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace close10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie.
             * Note that Math.abs(n) returns the absolute value of a number.
             *
             * close10(8, 13) → 8
             * close10(13, 8) → 8
             * close10(13, 7) → 0
             */
            Console.WriteLine(Close10(8, 13));
            Console.WriteLine(Close10(13, 8));
            Console.WriteLine(Close10(13, 7));
        }

        private static int Close10(int a, int b)
        {
            if (Math.Abs(a - 10) == Math.Abs(b - 10))
            {
                return 0;
            }
            else if (Math.Abs(a - 10) < Math.Abs(b - 10))
            {
                return a;
            }
            return b;
        }
    }
}

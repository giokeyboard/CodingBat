using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortaSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 ints, a and b, return their sum.
             * However, sums in the range 10..19 inclusive, are forbidden, so in that case just return 20.
             *
             * sortaSum(3, 4) → 7
             * sortaSum(9, 4) → 20
             * sortaSum(10, 11) → 21
             */
            Console.WriteLine(SortaSum(3, 4));
            Console.WriteLine(SortaSum(9, 4));
            Console.WriteLine(SortaSum(10, 11));
        }

        private static int SortaSum(int a, int b)
        {
            return (a + b >= 10 && a + b <= 19) ? 20 : a + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max1020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
             * or return 0 if neither is in that range.
             *
             * max1020(11, 19) → 19
             * max1020(19, 11) → 19
             * max1020(11, 9) → 11
             */
            Console.WriteLine(Max1020(11, 19));
            Console.WriteLine(Max1020(19, 11));
            Console.WriteLine(Max1020(11, 9));
        }

        private static int Max1020(int a, int b)
        {
            if (b > a)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (a >= 10 && a <= 20) { return a; }
            if (b >= 10 && b <= 20) { return b; }
            return 0;
        }
    }
}

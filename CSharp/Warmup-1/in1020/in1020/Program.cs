using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in1020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int values, return true if either of them is in the range 10..20 inclusive.
             *
             * in1020(12, 99) → true
             * in1020(21, 12) → true
             * in1020(8, 99) → false
             */
            Console.WriteLine(In1020(12, 99));
            Console.WriteLine(In1020(21, 12));
            Console.WriteLine(In1020(8, 99));
        }

        private static bool In1020(int a, int b)
        {
            return (a >= 10 && a <= 20) || (b >= 10 && b <= 20);
        }
    }
}

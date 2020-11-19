using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a number n, return true if n is in the range 1..10, inclusive.
             * Unless outsideMode is true, in which case return true if the number is less or equal to 1, or greater or equal to 10.
             *
             * in1To10(5, false) → true
             * in1To10(11, false) → false
             * in1To10(11, true) → true
             */
            Console.WriteLine(in1To10(5, false));
            Console.WriteLine(in1To10(11, false));
            Console.WriteLine(in1To10(11, true));
        }

        private static bool in1To10(int n, bool outsideMode)
        {
            return (outsideMode) ? n <= 1 || n >= 10 : n >= 1 && n <= 10;
        }
    }
}

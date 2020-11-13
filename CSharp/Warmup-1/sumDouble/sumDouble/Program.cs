using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two int values, return their sum. Unless the two values are the same, then return double their sum.
             *
             * sumDouble(1, 2) → 3
             * sumDouble(3, 2) → 5
             * sumDouble(2, 2) → 8
             */
            Console.WriteLine(SumDouble(1, 2));
            Console.WriteLine(SumDouble(3, 2));
            Console.WriteLine(SumDouble(2, 2));
        }

        private static int SumDouble(int a, int b)
        {
            return (a == b) ? 2 * (a + b) : a + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intMax
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given three int values, a b c, return the largest.
             *
             * intMax(1, 2, 3) → 3
             * intMax(1, 3, 2) → 3
             * intMax(3, 2, 1) → 3
             */
            Console.WriteLine(IntMax(1, 2, 3));
            Console.WriteLine(IntMax(1, 3, 2));
            Console.WriteLine(IntMax(3, 2, 1));
        }

        private static int IntMax(int a, int b, int c)
        {
            int max = (a > b) ? a : b;
            return (max > c) ? max : c;
        }
    }
}

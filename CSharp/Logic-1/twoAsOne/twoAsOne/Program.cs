using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoAsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given three ints, a b c, return true if it is possible to add two of the ints to get the third.
             *
             * twoAsOne(1, 2, 3) → true
             * twoAsOne(3, 1, 2) → true
             * twoAsOne(3, 2, 2) → false
             */
            Console.WriteLine(TwoAsOne(1, 2, 3));
            Console.WriteLine(TwoAsOne(3, 1, 2));
            Console.WriteLine(TwoAsOne(3, 2, 2));
        }

        private static bool TwoAsOne(int a, int b, int c)
        {
            return a + b == c || b + c == a || a + c == b;
        }
    }
}

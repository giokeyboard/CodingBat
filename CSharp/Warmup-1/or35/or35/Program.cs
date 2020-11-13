using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given non-negative number is a multiple of 3 or a multiple of 5.
             *  Use the % "mod" operator -- see Introduction to Mod
             *
             * or35(3) → true
             * or35(10) → true
             * or35(8) → false
             */
            Console.WriteLine(Or35(3));
            Console.WriteLine(Or35(10));
            Console.WriteLine(Or35(8));
        }

        private static bool Or35(int n)
        {
            return n % 3 == 0 || n % 5 == 0;
        }
    }
}

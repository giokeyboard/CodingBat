using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given non-negative number is 1 or 2 less than a multiple of 20.
             * So for example 38 and 39 return true, but 40 returns false. See also: Introduction to Mod
             *
             * less20(18) → true
             * less20(19) → true
             * less20(20) → false
             */
            Console.WriteLine(less20(18));
            Console.WriteLine(less20(19));
            Console.WriteLine(less20(20));
        }

        private static bool less20(int n)
        {
            return Math.Abs((n % 20) - 20) <= 2 && Math.Abs((n % 20) - 20) > 0;
        }
    }
}

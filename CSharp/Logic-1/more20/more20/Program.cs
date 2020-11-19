using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given non-negative number is 1 or 2 more than a multiple of 20.
             * See also: Introduction to Mod
             *
             * more20(20) → false
             * more20(21) → true
             * more20(22) → true
             */
            Console.WriteLine(more20(20));
            Console.WriteLine(more20(21));
            Console.WriteLine(more20(22));
        }

        private static bool more20(int n)
        {
            return n % 20 <= 2 && n % 20 > 0;
        }
    }
}

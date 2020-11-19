using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say a number is special if it is a multiple of 11 or if it is one more than a multiple of 11.
             * Return true if the given non-negative number is special. Use the % "mod" operator -- see Introduction to Mod
             *
             * specialEleven(22) → true
             * specialEleven(23) → true
             * specialEleven(24) → false
             */
            Console.WriteLine(specialEleven(22));
            Console.WriteLine(specialEleven(23));
            Console.WriteLine(specialEleven(24));
        }

        private static bool specialEleven(int n)
        {
            return n % 11 <= 1;
        }
    }
}

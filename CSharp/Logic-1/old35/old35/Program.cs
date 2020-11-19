using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace old35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given non-negative number is a multiple of 3 or 5, but not both.
             * Use the % "mod" operator -- see Introduction to Mod
             *
             * old35(3) → true
             * old35(10) → true
             * old35(15) → false
             */
            Console.WriteLine(old35(3));
            Console.WriteLine(old35(10));
            Console.WriteLine(old35(15));
        }

        private static bool old35(int n)
        {
            return n % 15 != 0 && (n % 3 == 0 || n % 5 == 0);
        }
    }
}

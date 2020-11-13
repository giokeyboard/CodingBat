using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diff21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an int n, return the absolute difference between n and 21, 
             * except return double the absolute difference if n is over 21.
             * 
             * diff21(19) → 2
             * diff21(10) → 11
             * diff21(21) → 0
             */
            Console.WriteLine(diff21(19));
            Console.WriteLine(diff21(10));
            Console.WriteLine(diff21(21));
        }

        private static int diff21(int n)
        {
            return (n > 21) ? 2 * Math.Abs(n - 21) : Math.Abs(n - 21);
        }
    }
}

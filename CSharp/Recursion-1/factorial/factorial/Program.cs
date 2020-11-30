using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given n of 1 or more, return the factorial of n, which is n * (n-1) * (n-2) ... 1.
             * Compute the result recursively (without loops).
             *
             * factorial(1) → 1
             * factorial(2) → 2
             * factorial(3) → 6
             */
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(2));
            Console.WriteLine(Factorial(3));
        }

        private static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}

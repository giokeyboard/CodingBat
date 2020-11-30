using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The fibonacci sequence is a famous bit of mathematics, and it happens to have a recursive definition.
             * The first two values in the sequence are 0 and 1 (essentially 2 base cases).
             * Each subsequent value is the sum of the previous two values, so the whole sequence is:
             * 0, 1, 1, 2, 3, 5, 8, 13, 21 and so on.
             * Define a recursive fibonacci(n) method that returns the nth fibonacci number,
             * with n=0 representing the start of the sequence.
             *
             * fibonacci(0) → 0
             * fibonacci(1) → 1
             * fibonacci(2) → 1
             */
            Console.WriteLine(Fibonacci(0));
            Console.WriteLine(Fibonacci(1));
            Console.WriteLine(Fibonacci(2));
            Console.WriteLine(Fibonacci(7));
        }

        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

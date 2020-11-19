using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace love6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The number 6 is a truly great number. Given two int values, a and b, return true if either one is 6.
             * Or if their sum or difference is 6. Note: the function Math.abs(num) computes the absolute value of a number.
             *
             * love6(6, 4) → true
             * love6(4, 5) → false
             * love6(1, 5) → true
             */
            Console.WriteLine(Love6(6, 4));
            Console.WriteLine(Love6(4, 5));
            Console.WriteLine(Love6(1, 5));
        }

        private static bool Love6(int a, int b)
        {
            return (a == 6 || b == 6 || a + b == 6 || Math.Abs(a - b) == 6);
        }
    }
}

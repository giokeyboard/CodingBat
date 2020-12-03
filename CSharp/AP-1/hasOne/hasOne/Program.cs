using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasOne
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a positive int n, return true if it contains a 1 digit.
             * Note: use % to get the rightmost digit, and / to discard the rightmost digit.
             *
             * hasOne(10) → true
             * hasOne(22) → false
             * hasOne(220) → false
             */
            Console.WriteLine(HasOne(10));
            Console.WriteLine(HasOne(22));
            Console.WriteLine(HasOne(220));
        }

        private static bool HasOne(int n)
        {
            //Alternative approach (iterative)
            //while (n != 0)
            //{
            //    if (n % 10 == 1) return true;
            //    n /= 10;
            //}
            //return false;

            if (n % 10 == 1) return true;
            if (n / 10 == 0) return false;
            return HasOne(n / 10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nearHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an int n, return true if it is within 10 of 100 or 200.
             * Note: Math.abs(num) computes the absolute value of a number.
             *
             * nearHundred(93) → true
             * nearHundred(90) → true
             * nearHundred(89) → false
             */
            Console.WriteLine(NearHundred(93));
            Console.WriteLine(NearHundred(90));
            Console.WriteLine(NearHundred(89));

        }

        private static bool NearHundred(int n)
        {
            return Math.Abs(100 - n) <= 10 || Math.Abs(200 - n) <= 10;
        }
    }
}

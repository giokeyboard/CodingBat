﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makes10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 ints, a and b, return true if one if them is 10 or if their sum is 10.
             *
             * makes10(9, 10) → true
             * makes10(9, 9) → false
             * makes10(1, 9) → true
             */
            Console.WriteLine(Makes10(9, 10));
            Console.WriteLine(Makes10(9, 9));
            Console.WriteLine(Makes10(1, 9));
        }

        private static bool Makes10(int a, int b)
        {
            return a == 10 || b == 10 || a + b == 10;
        }
    }
}

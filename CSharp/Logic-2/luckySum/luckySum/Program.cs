﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luckySum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 3 int values, a b c, return their sum.
             * However, if one of the values is 13 then it does not count towards the sum and values to its right do not count.
             * So for example, if b is 13, then both b and c do not count.
             *
             * luckySum(1, 2, 3) → 6
             * luckySum(1, 2, 13) → 3
             * luckySum(1, 13, 3) → 1
             */
            Console.WriteLine(LuckySum(1, 2, 3));
            Console.WriteLine(LuckySum(1, 2, 13));
            Console.WriteLine(LuckySum(1, 13, 3));
        }

        private static int LuckySum(int a, int b, int c)
        {
            if (a == 13) return 0;
            if (b == 13) return a;
            if (c == 13) return a + b;
            return a + b + c;
        }
    }
}

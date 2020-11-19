﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given three ints, a b c, return true if b is greater than a, and c is greater than b.
             * However, with the exception that if "bOk" is true, b does not need to be greater than a.
             *
             * inOrder(1, 2, 4, false) → true
             * inOrder(1, 2, 1, false) → false
             * inOrder(1, 1, 2, true) → true
             */
            Console.WriteLine(inOrder(1, 2, 4, false));
            Console.WriteLine(inOrder(1, 2, 1, false));
            Console.WriteLine(inOrder(1, 1, 2, true));
        }

        private static bool inOrder(int a, int b, int c, bool bOk)
        {
            return (bOk) ? c > b : b > a && c > b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace closeFar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given three ints, a b c, return true if one of b or c is "close" (differing from a by at most 1),
             * while the other is "far", differing from both other values by 2 or more.
             * Note: Math.abs(num) computes the absolute value of a number.
             *
             * closeFar(1, 2, 10) → true
             * closeFar(1, 2, 3) → false
             * closeFar(4, 1, 3) → true
             */
            Console.WriteLine(CloseFar(1, 2, 10));
            Console.WriteLine(CloseFar(1, 2, 3));
            Console.WriteLine(CloseFar(4, 1, 3));
        }

        private static bool CloseFar(int a, int b, int c)
        {
            return IsClose(a, b) && (IsFar(c, a, b)) || IsClose(a, c) && IsFar(b, a, c);
        }

        private static bool IsFar(int n1, int n2, int n3)
        {
            return Math.Abs(n1 - n2) >= 2 && Math.Abs(n1 - n3) >= 2;
        }

        private static bool IsClose(int n1, int n2) { return Math.Abs(n1 - n2) <= 1; }
    }
}

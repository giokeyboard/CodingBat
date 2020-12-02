using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strCopies
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a non-empty substring sub,
             * compute recursively if at least n copies of sub appear in the string somewhere, possibly with overlapping.
             * N will be non-negative.
             *
             * strCopies("catcowcat", "cat", 2) → true
             * strCopies("catcowcat", "cow", 2) → false
             * strCopies("catcowcat", "cow", 1) → true
             */
            Console.WriteLine(strCopies("catcowcat", "cat", 2));
            Console.WriteLine(strCopies("catcowcat", "cow", 2));
            Console.WriteLine(strCopies("catcowcat", "cow", 1));
        }

        private static bool strCopies(string str, string sub, int n)
        {
            if (n == 0) return true;
            if (str.Length < sub.Length) return n <= 0;
            if (str.StartsWith(sub)) return strCopies(str.Substring(1), sub, n - 1);
            return strCopies(str.Substring(1), sub, n);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefixAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, consider the prefix string made of the first N chars of the string.
             * Does that prefix string appear somewhere else in the string?
             * Assume that the string is not empty and that N is in the range 1..str.length().
             *
             * prefixAgain("abXYabc", 1) → true
             * prefixAgain("abXYabc", 2) → true
             * prefixAgain("abXYabc", 3) → false
             */
            Console.WriteLine(PrefixAgain("abXYabc", 1));
            Console.WriteLine(PrefixAgain("abXYabc", 2));
            Console.WriteLine(PrefixAgain("abXYabc", 3));
        }

        private static bool PrefixAgain(string str, int n)
        {
            if (n >= ((str.Length / 2) + 1)) return false;
            for (int i = n; i <= str.Length - n; i++)
            {
                if (str.Substring(i).StartsWith(str.Substring(0, n))) return true;
            }
            return false;
        }
    }
}

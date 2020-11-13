using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-empty string and an int n, return a new string where the char at index n has been removed.
             * The value of n will be a valid index of a char in the original string
             * (i.e. n will be in the range 0..str.length()-1 inclusive).
             *
             * missingChar("kitten", 1) → "ktten"
             * missingChar("kitten", 0) → "itten"
             * missingChar("kitten", 4) → "kittn"
             */
            Console.WriteLine(MissingChar("kitten", 1));
            Console.WriteLine(MissingChar("kitten", 0));
            Console.WriteLine(MissingChar("kitten", 4));
        }

        private static string MissingChar(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(n + 1);
        }
    }
}

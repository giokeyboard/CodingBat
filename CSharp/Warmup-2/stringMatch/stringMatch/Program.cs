﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 strings, a and b, return the number of the positions where
             * they contain the same length 2 substring.
             * So "xxcaazz" and "xxbaaz" yields 3, since the "xx",
             * "aa", and "az" substrings appear in the same place in both strings.
             *
             * stringMatch("xxcaazz", "xxbaaz") → 3
             * stringMatch("abc", "abc") → 2
             * stringMatch("abc", "axc") → 0
             */
            Console.WriteLine(StringMatch("xxcaazz", "xxbaaz"));
            Console.WriteLine(StringMatch("abc", "abc"));
            Console.WriteLine(StringMatch("abc", "axc"));
        }

        private static int StringMatch(string a, string b)
        {
            int count = 0;
            int len = (a.Length < b.Length) ? a.Length : b.Length;

            for (int i = 0; i < len - 1; i++)
            {
                if (a.Substring(i, 2).Equals(b.Substring(i, 2))) { count++; }
            }

            return count;
        }
    }
}

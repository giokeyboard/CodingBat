using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchUp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 arrays that are the same length containing strings, compare the 1st string in one array to the 1st
             * string in the other array, the 2nd to the 2nd and so on. Count the number of times that the 2 strings are
             * non-empty and start with the same char. The strings may be any length, including 0.
             *
             * matchUp(["aa", "bb", "cc"], ["aaa", "xx", "bb"]) → 1
             * matchUp(["aa", "bb", "cc"], ["aaa", "b", "bb"]) → 2
             * matchUp(["aa", "bb", "cc"], ["", "", "ccc"]) → 1
             */
            Console.WriteLine(MatchUp(new String[] { "aa", "bb", "cc" }, new String[] { "aaa", "xx", "bb" }));
            Console.WriteLine(MatchUp(new String[] { "aa", "bb", "cc" }, new String[] { "aaa", "b", "bb" }));
            Console.WriteLine(MatchUp(new String[] { "aa", "bb", "cc" }, new String[] { "", "", "ccc" }));
        }

        private static int MatchUp(string[] a, string[] b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!string.IsNullOrEmpty(a[i]) && !string.IsNullOrEmpty(b[i]) && a[i][0] == b[i][0]) count++;
            }
            return count;
        }
    }
}

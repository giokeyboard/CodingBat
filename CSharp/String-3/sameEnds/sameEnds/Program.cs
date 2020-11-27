using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sameEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return the longest substring that appears at both the beginning and
             * end of the string without overlapping. For example, sameEnds("abXab") is "ab".
             *
             * sameEnds("abXYab") → "ab"
             * sameEnds("xx") → "x"
             * sameEnds("xxx") → "x"
             */
            Console.WriteLine(SameEnds("abXYab"));
            Console.WriteLine(SameEnds("xx"));
            Console.WriteLine(SameEnds("xxx"));
        }

        private static string SameEnds(string str)
        {
            string first = str.Substring(0, str.Length / 2);
            string second = str.Substring((str.Length % 2 == 0) ? str.Length / 2 : str.Length / 2 + 1);

            while (!first.Equals(second))
            {
                first = first.Substring(0, first.Length - 1);
                second = second.Substring(1);
            }

            return first;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively (no loops) the number of "11" substrings in the string.
             * The "11" substrings should not overlap.
             *
             * count11("11abc11") → 2
             * count11("abc11x11x11") → 3
             * count11("111") → 1
             */
            Console.WriteLine(Count11("11abc11"));
            Console.WriteLine(Count11("abc11x11x11"));
            Console.WriteLine(Count11("111"));
        }

        private static int Count11(string str)
        {
            if (str.Length < 2) return 0;
            if (str.StartsWith("11")) return 1 + Count11(str.Substring(2));
            return Count11(str.Substring(1));
        }
    }
}

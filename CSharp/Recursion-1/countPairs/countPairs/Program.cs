using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a "pair" in a string is two instances of a char separated by a char.
             * So "AxA" the A's make a pair. Pair's can overlap, so "AxAxA" contains 3 pairs -- 2 for A and 1 for x.
             * Recursively compute the number of pairs in the given string.
             *
             * countPairs("axa") → 1
             * countPairs("axax") → 2
             * countPairs("axbx") → 1
             */
            Console.WriteLine(CountPairs("axa"));
            Console.WriteLine(CountPairs("axax"));
            Console.WriteLine(CountPairs("axbx"));
        }

        private static int CountPairs(string str)
        {
            if (str.Length < 3) return 0;
            if (str[0] == str[2]) return 1 + CountPairs(str.Substring(1));
            return CountPairs(str.Substring(1));
        }
    }
}

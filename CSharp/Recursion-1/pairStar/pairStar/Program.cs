using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairStar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively a new string where identical chars that are
             * adjacent in the original string are separated from each other by a "*".
             *
             * pairStar("hello") → "hel*lo"
             * pairStar("xxyy") → "x*xy*y"
             * pairStar("aaaa") → "a*a*a*a"
             */
            Console.WriteLine(PairStar("hello"));
            Console.WriteLine(PairStar("xxyy"));
            Console.WriteLine(PairStar("aaaa"));
        }

        private static string PairStar(string str)
        {
            if (str.Length < 2) return str;
            if (str[0] == str[1]) return str[0] + "*" + PairStar(str.Substring(1));
            return str[0] + PairStar(str.Substring(1));
        }
    }
}

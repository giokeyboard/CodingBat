using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strDist
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a non-empty substring sub,
             * compute recursively the largest substring which starts and ends with sub and return its length.
             *
             * strDist("catcowcat", "cat") → 9
             * strDist("catcowcat", "cow") → 3
             * strDist("cccatcowcatxx", "cat") → 9
             */
            Console.WriteLine(StrDist("catcowcat", "cat"));
            Console.WriteLine(StrDist("catcowcat", "cow"));
            Console.WriteLine(StrDist("cccatcowcatxx", "cat"));
        }

        private static int StrDist(string str, string sub)
        {
            if (str.Length < sub.Length) return 0;
            if (str.StartsWith(sub) && str.EndsWith(sub)) return str.Length;
            if (!str.StartsWith(sub)) return StrDist(str.Substring(1), sub);
            return StrDist(str.Substring(0, str.Length - 1), sub);
        }
    }
}

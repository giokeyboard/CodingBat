using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strCount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a non-empty substring sub,
             * compute recursively the number of times that sub appears in the string, without the sub strings overlapping.
             *
             * strCount("catcowcat", "cat") → 2
             * strCount("catcowcat", "cow") → 1
             * strCount("catcowcat", "dog") → 0
             */
            Console.WriteLine(StrCount("catcowcat", "cat"));
            Console.WriteLine(StrCount("catcowcat", "cow"));
            Console.WriteLine(StrCount("catcowcat", "dog"));
        }

        private static int StrCount(string str, string sub)
        {
            if (str.Length < sub.Length) return 0;
            if (str.StartsWith(sub)) return 1 + StrCount(str.Substring(sub.Length), sub);
            return StrCount(str.Substring(1), sub);
        }
    }
}

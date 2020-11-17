using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonStart
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 strings, return their concatenation, except omit the first char of each.
             * The strings will be at least length 1.
             *
             * nonStart("Hello", "There") → "ellohere"
             * nonStart("java", "code") → "avaode"
             * nonStart("shotl", "java") → "hotlava"
             */
            Console.WriteLine(NonStart("Hello", "There"));
            Console.WriteLine(NonStart("java", "code"));
            Console.WriteLine(NonStart("shotl", "java"));
        }

        private static string NonStart(string a, string b)
        {
            return a.Substring(1) + b.Substring(1);
        }
    }
}

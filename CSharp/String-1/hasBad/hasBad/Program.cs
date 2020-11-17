using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasBad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return true if "bad" appears starting at index 0 or 1 in the string,
             * such as with "badxxx" or "xbadxx" but not "xxbadxx".
             * The string may be any length, including 0. Note: use .equals() to compare 2 strings.
             *
             * hasBad("badxx") → true
             * hasBad("xbadxx") → true
             * hasBad("xxbadxx") → false
             */
            Console.WriteLine(hasBad("badxx"));
            Console.WriteLine(hasBad("xbadxx"));
            Console.WriteLine(hasBad("xxbadxx"));
        }

        private static bool hasBad(string v)
        {
            return v.StartsWith("bad") || (v.Length > 0 && v.Substring(1).StartsWith("bad"));
        }
    }
}

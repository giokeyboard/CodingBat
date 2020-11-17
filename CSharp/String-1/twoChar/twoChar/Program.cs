using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and an index, return a string length 2 starting at the given index.
             * If the index is too big or too small to define a string length 2, use the first 2 chars.
             * The string length will be at least 2.
             *
             * twoChar("java", 0) → "ja"
             * twoChar("java", 2) → "va"
             * twoChar("java", 3) → "ja"
             */
            Console.WriteLine(twoChar("java", 0));
            Console.WriteLine(twoChar("java", 2));
            Console.WriteLine(twoChar("java", 3));
        }

        private static string twoChar(string str, int index)
        {
            if (index > str.Length - 2 || index < 0) { return str.Substring(0, 2); }
            return str.Substring(index, 2);
        }
    }
}

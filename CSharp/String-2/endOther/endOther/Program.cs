using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endOther
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings, return true if either of the strings appears at the very end of the other string,
             * ignoring upper/lower case differences (in other words, the computation should not be "case sensitive").
             * Note: str.toLowerCase() returns the lowercase version of a string.
             *
             * endOther("Hiabc", "abc") → true
             * endOther("AbC", "HiaBc") → true
             * endOther("abc", "abXabc") → true
             */
            Console.WriteLine(EndOther("Hiabc", "abc"));
            Console.WriteLine(EndOther("AbC", "HiaBc"));
            Console.WriteLine(EndOther("abc", "abXabc"));
        }

        private static bool EndOther(string a, string b)
        {
            return a.EndsWith(b, StringComparison.InvariantCultureIgnoreCase) || b.EndsWith(a, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}

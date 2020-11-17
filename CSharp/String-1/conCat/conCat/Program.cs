using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conCat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings, append them together (known as "concatenation") and return the result.
             * However, if the concatenation creates a double-char,
             * then omit one of the chars, so "abc" and "cat" yields "abcat".
             *
             * conCat("abc", "cat") → "abcat"
             * conCat("dog", "cat") → "dogcat"
             * conCat("abc", "") → "abc"
             */
            Console.WriteLine(ConCat("abc", "cat"));
            Console.WriteLine(ConCat("dog", "cat"));
            Console.WriteLine(ConCat("abc", ""));
        }

        private static string ConCat(string a, string b)
        {
            return (a.Length == 0 || b.Length == 0 || a[a.Length - 1] != b[0]) ? a + b : a + b.Substring(1);
        }
    }
}

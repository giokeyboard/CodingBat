using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minCat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings, append them together (known as "concatenation") and return the result.
             * However, if the strings are different lengths,
             * omit chars from the longer string so it is the same length as the shorter string.
             * So "Hello" and "Hi" yield "loHi". The strings may be any length.
             *
             * minCat("Hello", "Hi") → "loHi"
             * minCat("Hello", "java") → "ellojava"
             * minCat("java", "Hello") → "javaello"
             */
            Console.WriteLine(MinCat("Hello", "Hi"));
            Console.WriteLine(MinCat("Hello", "java"));
            Console.WriteLine(MinCat("java", "Hello"));
        }

        private static string MinCat(string a, string b)
        {
            int len = Math.Min(a.Length, b.Length);
            return a.Substring(a.Length - len) + b.Substring(b.Length - len);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastChars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 strings, a and b, return a new string made of the first char of a and the last char of b,
             * so "yo" and "java" yields "ya". If either string is length 0, use '@' for its missing char.
             *
             * lastChars("last", "chars") → "ls"
             * lastChars("yo", "java") → "ya"
             * lastChars("hi", "") → "h@"
             */
            Console.WriteLine(lastChars("last", "chars"));
            Console.WriteLine(lastChars("yo", "java"));
            Console.WriteLine(lastChars("hi", ""));
        }

        private static string lastChars(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((a.Length == 0) ? '@' : a[0]);
            sb.Append((b.Length == 0) ? '@' : b[b.Length - 1]);
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 strings, a and b, return a string of the form short+long+short,
             * with the shorter string on the outside and the longer string on the inside.
             * The strings will not be the same length, but they may be empty (length 0).
             *
             * comboString("Hello", "hi") → "hiHellohi"
             * comboString("hi", "Hello") → "hiHellohi"
             * comboString("aaa", "b") → "baaab"
             */
            Console.WriteLine(ComboString("Hello", "hi"));
            Console.WriteLine(ComboString("hi", "Hello"));
            Console.WriteLine(ComboString("aaa", "b"));
        }

        private static string ComboString(string a, string b)
        {
            string shorter = (a.Length < b.Length) ? a : b;
            string longer = (shorter.Equals(a)) ? b : a;
            return shorter + longer + shorter;
        }
    }
}

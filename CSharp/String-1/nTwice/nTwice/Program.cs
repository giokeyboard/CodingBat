using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTwice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and an int n, return a string made of the first and last n chars from the string.
             * The string length will be at least n.
             *
             * nTwice("Hello", 2) → "Helo"
             * nTwice("Chocolate", 3) → "Choate"
             * nTwice("Chocolate", 1) → "Ce"
             */
            Console.WriteLine(nTwice("Hello", 2));
            Console.WriteLine(nTwice("Chocolate", 3));
            Console.WriteLine(nTwice("Chocolate", 1));
        }

        private static string nTwice(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n, n);
        }
    }
}

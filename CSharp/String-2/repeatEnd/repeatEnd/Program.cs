using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and an int n, return a string made of n repetitions of the last n characters of the string.
             * You may assume that n is between 0 and the length of the string, inclusive.
             *
             * repeatEnd("Hello", 3) → "llollollo"
             * repeatEnd("Hello", 2) → "lolo"
             * repeatEnd("Hello", 1) → "o"
             */
            Console.WriteLine(repeatEnd("Hello", 3));
            Console.WriteLine(repeatEnd("Hello", 2));
            Console.WriteLine(repeatEnd("Hello", 1));
        }

        private static string repeatEnd(string str, int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(str.Substring(str.Length - n));
            }
            return sb.ToString();
        }
    }
}

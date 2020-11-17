using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return the string made of its first two chars, so the String "Hello" yields "He".
             * If the string is shorter than length 2, return whatever there is, so "X" yields "X",
             * and the empty string "" yields the empty string "".
             * Note that str.length() returns the length of a string.
             *
             * firstTwo("Hello") → "He"
             * firstTwo("abcdefg") → "ab"
             * firstTwo("ab") → "ab"
             */
            Console.WriteLine(FirstTwo("Hello"));
            Console.WriteLine(FirstTwo("abcdefg"));
            Console.WriteLine(FirstTwo("ab"));
        }

        private static string FirstTwo(string str)
        {
            return (str.Length < 3) ? str : str.Substring(0, 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a new string made of 3 copies of the last 2 chars of the original string.
             * The string length will be at least 2.
             *
             * extraEnd("Hello") → "lololo"
             * extraEnd("ab") → "ababab"
             * extraEnd("Hi") → "HiHiHi"
             */
            Console.WriteLine(ExtraEnd("Hello"));
            Console.WriteLine(ExtraEnd("ab"));
            Console.WriteLine(ExtraEnd("Hi"));
        }

        private static string ExtraEnd(string str)
        {
            return str.Substring(str.Length - 2) + str.Substring(str.Length - 2) + str.Substring(str.Length - 2);
        }
    }
}

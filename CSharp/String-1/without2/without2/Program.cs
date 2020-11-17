using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace without2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, if a length 2 substring appears at both its beginning and end,
             * return a string without the substring at the beginning, so "HelloHe" yields "lloHe".
             * The substring may overlap with itself, so "Hi" yields "". Otherwise, return the original string unchanged.
             *
             * without2("HelloHe") → "lloHe"
             * without2("HelloHi") → "HelloHi"
             * without2("Hi") → ""
             */
            Console.WriteLine(without2("HelloHe"));
            Console.WriteLine(without2("HelloHi"));
            Console.WriteLine(without2("Hi"));
        }

        private static string without2(string str)
        {
            if (str.Length <= 1 || !str.Substring(0, 2).Equals(str.Substring(str.Length - 2)))
            {
                return str;
            }
            return str.Substring(2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sameStarChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Returns true if for every '*' (star) in the string, if there are chars both immediately before and after the star,
             * they are the same.
             *
             * sameStarChar("xy*yzz") → true
             * sameStarChar("xy*zzz") → false
             * sameStarChar("*xa*az") → true
             */
            Console.WriteLine(sameStarChar("xy*yzz"));
            Console.WriteLine(sameStarChar("xy*zzz"));
            Console.WriteLine(sameStarChar("*xa*az"));
        }

        private static bool sameStarChar(string str)
        {
            for (int i = 1; i < str.Length - 1; i++)
            {
                if ((str[i] == '*') && (str[i - 1] != str[i + 1])) { return false; }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringClean
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return recursively a "cleaned" string where adjacent chars that are the same
             * have been reduced to a single char. So "yyzzza" yields "yza".
             *
             * stringClean("yyzzza") → "yza"
             * stringClean("abbbcdd") → "abcd"
             * stringClean("Hello") → "Helo"
             */
            Console.WriteLine(StringClean("yyzzza"));
            Console.WriteLine(StringClean("abbbcdd"));
            Console.WriteLine(StringClean("Hello"));
        }

        private static string StringClean(string str)
        {
            if (str.Length < 2) return str;
            if (str[0] != str[1]) return str[0] + StringClean(str.Substring(1));
            return StringClean(str.Substring(1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allStar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively a new string where all the adjacent chars are now separated by a "*".
             *
             * allStar("hello") → "h*e*l*l*o"
             * allStar("abc") → "a*b*c"
             * allStar("ab") → "a*b"
             */
            Console.WriteLine(AllStar("hello"));
            Console.WriteLine(AllStar("abc"));
            Console.WriteLine(AllStar("ab"));
        }

        private static string AllStar(string str)
        {
            if (str.Length <= 1) return str;
            return str[0] + "*" + AllStar(str.Substring(1));
        }
    }
}

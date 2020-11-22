using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute a new string by moving the first char to come after the next two chars, so "abc" yields "bca".
             * Repeat this process for each subsequent group of 3 chars, so "abcdef" yields "bcaefd".
             * Ignore any group of fewer than 3 chars at the end.
             *
             * oneTwo("abc") → "bca"
             * oneTwo("tca") → "cat"
             * oneTwo("tcagdo") → "catdog"
             */
            Console.WriteLine(OneTwo("abc"));
            Console.WriteLine(OneTwo("tca"));
            Console.WriteLine(OneTwo("tcagdo"));
        }

        private static string OneTwo(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length - 2; i += 3)
            {
                if (str.Length - i > 2) sb.Append(str[i + 1] + "" + str[i + 2] + "" + str[i]);
            }
            return sb.ToString();
        }
    }
}

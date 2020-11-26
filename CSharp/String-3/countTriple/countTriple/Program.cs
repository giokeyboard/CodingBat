using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a "triple" in a string is a char appearing three times in a row.
             * Return the number of triples in the given string. The triples may overlap.
             *
             * countTriple("abcXXXabc") → 1
             * countTriple("xxxabyyyycd") → 3
             * countTriple("a") → 0
             */
            Console.WriteLine(CountTriple("abcXXXabc"));
            Console.WriteLine(CountTriple("xxxabyyyycd"));
            Console.WriteLine(CountTriple("a"));
        }

        private static int CountTriple(string str)
        {
            int countTriple = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == str[i + 1] && str[i + 1] == str[i + 2]) countTriple++;
            }
            return countTriple;
        }
    }
}

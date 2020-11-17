using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string of any length, return a new string where the last 2 chars,
             * if present, are swapped, so "coding" yields "codign".
             *
             * lastTwo("coding") → "codign"
             * lastTwo("cat") → "cta"
             * lastTwo("ab") → "ba"
             */
            Console.WriteLine(lastTwo("coding"));
            Console.WriteLine(lastTwo("cat"));
            Console.WriteLine(lastTwo("ab"));
        }

        private static string lastTwo(string str)
        {
            return str.Length < 2 ? str : str.Substring(0, str.Length - 2) + str[str.Length - 1] + str[str.Length - 2];
        }
    }
}

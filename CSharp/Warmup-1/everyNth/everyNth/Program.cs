using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace everyNth
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-empty string and an int N, return the string made starting with char 0,
             * and then every Nth char of the string. So if N is 3, use char 0, 3, 6, ... and so on. N is 1 or more.
             *
             * everyNth("Miracle", 2) → "Mrce"
             * everyNth("abcdefg", 2) → "aceg"
             * everyNth("abcdefg", 3) → "adg"
             */
            Console.WriteLine(EveryNth("Miracle", 2));
            Console.WriteLine(EveryNth("abcdefg", 2));
            Console.WriteLine(EveryNth("abcdefg", 3));
        }

        private static string EveryNth(string str, int n)
        {
            string result = "" + str[0];
            for (int i = n; i < str.Length; i += n)
            {
                result += str[i];
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyzThere
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given string contains an appearance of "xyz" where
             * the xyz is not directly preceeded by a period (.). So "xxyz" counts but "x.xyz" does not.
             *
             * xyzThere("abcxyz") → true
             * xyzThere("abc.xyz") → false
             * xyzThere("xyz.abc") → true
             */
            Console.WriteLine(XyzThere("abcxyz"));
            Console.WriteLine(XyzThere("abc.xyz"));
            Console.WriteLine(XyzThere("xyz.abc"));
        }

        private static bool XyzThere(string str)
        {
            if (str.StartsWith("xyz")) return true;
            for (int i = 1; i < str.Length - 2; i++)
            {
                if (str[i - 1] != '.' && str.Substring(i, 3).Equals("xyz")) return true;
            }
            return false;
        }
    }
}

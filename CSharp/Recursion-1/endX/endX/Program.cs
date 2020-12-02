using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively a new string where all the lowercase 'x' chars
             * have been moved to the end of the string.
             *
             * endX("xxre") → "rexx"
             * endX("xxhixx") → "hixxxx"
             * endX("xhixhix") → "hihixxx"
             */
            Console.WriteLine(EndX("xxre"));
            Console.WriteLine(EndX("xxhixx"));
            Console.WriteLine(EndX("xhixhix"));
        }

        private static string EndX(string str)
        {
            if (str.Length == 0) return str;
            if (str[0] == 'x') return EndX(str.Substring(1)) + str[0];
            return str[0] + EndX(str.Substring(1));
        }
    }
}

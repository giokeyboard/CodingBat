using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a version where all the "x" have been removed.
             * Except an "x" at the very start or end should not be removed.
             *
             * stringX("xxHxix") → "xHix"
             * stringX("abxxxcd") → "abcd"
             * stringX("xabxxxcdx") → "xabcdx"
             */
            Console.WriteLine(StringX("xxHxix"));
            Console.WriteLine(StringX("abxxxcd"));
            Console.WriteLine(StringX("xabxxxcdx"));
        }

        private static string StringX(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (!((i > 0 && i < str.Length - 1) && str.Substring(i, 1).Equals("x"))) { sb.Append(str[i]); }
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings, base and remove, return a version of the base string where all instances of the remove string
             * have been removed (not case sensitive). You may assume that the remove string is length 1 or more.
             * Remove only non-overlapping instances, so with "xxx" removing "xx" leaves "x".
             *
             * withoutString("Hello there", "llo") → "He there"
             * withoutString("Hello there", "e") → "Hllo thr"
             * withoutString("Hello there", "x") → "Hello there"
             */
            Console.WriteLine(WithoutString("Hello there", "llo"));
            Console.WriteLine(WithoutString("Hello there", "e"));
            Console.WriteLine(WithoutString("Hello there", "x"));
        }

        private static string WithoutString(string @base, string remove)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < @base.Length; i++)
            {
                if (!@base.ToLower().Substring(i).StartsWith(remove.ToLower()))
                {
                    sb.Append(@base[i]);
                } else
                {
                    i += remove.Length - 1;
                }
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutX2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, if one or both of the first 2 chars is 'x',
             * return the string without those 'x' chars, and otherwise return the string unchanged.
             * This is a little harder than it looks.
             *
             * withoutX2("xHi") → "Hi"
             * withoutX2("Hxi") → "Hi"
             * withoutX2("Hi") → "Hi"
             */
            Console.WriteLine(WithoutX2("xHi"));
            Console.WriteLine(WithoutX2("Hxi"));
            Console.WriteLine(WithoutX2("Hi"));
        }

        private static string WithoutX2(string str)
        {
            StringBuilder sb = new StringBuilder();

            if (str.Length > 0 && str[0] != 'x') { sb.Append(str[0]); }
            if (str.Length > 1 && str[1] != 'x') { sb.Append(str[1]); }
            if (str.Length > 2) { sb.Append(str.Substring(2)); }

            return sb.ToString();
        }
    }
}

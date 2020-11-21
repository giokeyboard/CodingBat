using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings, a and b, create a bigger string made of the first char of a, the first char of b,
             * the second char of a, the second char of b, and so on. Any leftover chars go at the end of the result.
             *
             * mixString("abc", "xyz") → "axbycz"
             * mixString("Hi", "There") → "HTihere"
             * mixString("xxxx", "There") → "xTxhxexre"
             */
            Console.WriteLine(MixString("abc", "xyz"));
            Console.WriteLine(MixString("Hi", "There"));
            Console.WriteLine(MixString("xxxx", "There"));
        }

        private static string MixString(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            int i = 0;
            while (i < a.Length && i < b.Length)
            {
                sb.Append(a[i]);
                sb.Append(b[i]);
                i++;
            }

            if (i == a.Length) sb.Append(b.Substring(i));
            else if (i == b.Length) sb.Append(a.Substring(i));

            return sb.ToString();
        }
    }
}

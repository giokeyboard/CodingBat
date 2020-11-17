using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deFront
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a version without the first 2 chars.
             * Except keep the first char if it is 'a' and keep the second char if it is 'b'.
             * The string may be any length. Harder than it looks.
             *
             * deFront("Hello") → "llo"
             * deFront("java") → "va"
             * deFront("away") → "aay"
             */
            Console.WriteLine(DeFront("Hello"));
            Console.WriteLine(DeFront("java"));
            Console.WriteLine(DeFront("away"));
        }

        private static string DeFront(string str)
        {
            StringBuilder sb = new StringBuilder();
            if (str.Length > 0 && str[0] == 'a') { sb.Append(str[0]); }
            if (str.Length > 1) { sb.Append((str[1] == 'b') ? str.Substring(1) : str.Substring(2)); }
            return sb.ToString();
        }
    }
}

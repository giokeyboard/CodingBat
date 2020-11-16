using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringSplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given a non-empty string like "Code" return a string like "CCoCodCode".
            *
            * stringSplosion("Code") → "CCoCodCode"
            * stringSplosion("abc") → "aababc"
            * stringSplosion("ab") → "aab"
            */
            Console.WriteLine(StringSplosion("Code"));
            Console.WriteLine(StringSplosion("abc"));
            Console.WriteLine(StringSplosion("ab"));
        }

        private static string StringSplosion(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length + 1; i++)
            {
                sb.Append(str.Substring(0, i));
            }
            return sb.ToString();
        }
    }
}

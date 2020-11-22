using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return a version of the given string, where for every star (*) in the string the star and the chars
             * immediately to its left and right are gone. So "ab*cd" yields "ad" and "ab**cd" also yields "ad".
             *
             * starOut("ab*cd") → "ad"
             * starOut("ab**cd") → "ad"
             * starOut("sm*eilly") → "silly"
             */
            Console.WriteLine(StarOut("ab*cd"));
            Console.WriteLine(StarOut("ab**cd"));
            Console.WriteLine(StarOut("sm*eilly"));
        }

        private static string StarOut(string str)
        {
            if (!str.Contains("*")) return str;
            if (str.Length < 3) return "";

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*' || (i > 0 && str[i - 1] == '*')) continue;
                if (i < str.Length - 1 && str[i + 1] == '*') continue;
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}

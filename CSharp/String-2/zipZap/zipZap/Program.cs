using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zipZap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Look for patterns like "zip" and "zap" in the string -- length-3, starting with 'z' and ending with 'p'.
             * Return a string where for all such words, the middle letter is gone, so "zipXzap" yields "zpXzp".
             *
             * zipZap("zipXzap") → "zpXzp"
             * zipZap("zopzop") → "zpzp"
             * zipZap("zzzopzop") → "zzzpzp"
             */
            Console.WriteLine(zipZap("zipXzap"));
            Console.WriteLine(zipZap("zopzop"));
            Console.WriteLine(zipZap("zzzopzop"));
        }

        private static string zipZap(string str)
        {
            if (str.Length < 3) return str;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z' && str[i + 2] == 'p')
                {
                    sb.Append(str[i] + "" + str[i + 2]);
                    i += 2;
                }
                else sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}

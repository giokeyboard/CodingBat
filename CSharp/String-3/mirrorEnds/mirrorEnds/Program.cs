using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mirrorEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, look for a mirror image (backwards) string at both the beginning and end of the given string.
             * In other words, zero or more characters at the very beginning of the given string, and at the very end of the
             * string in reverse order (possibly overlapping). For example, the string "abXYZba" has the mirror end "ab".
             *
             * mirrorEnds("abXYZba") → "ab"
             * mirrorEnds("abca") → "a"
             * mirrorEnds("aba") → "aba"
             */
            Console.WriteLine(MirrorEnds("abXYZba"));
            Console.WriteLine(MirrorEnds("abca"));
            Console.WriteLine(MirrorEnds("aba"));
        }

        private static string MirrorEnds(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[str.Length - 1 - i]) sb.Append(str[i]);
                else break;
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a non-empty word string, return a string made of each char just before and just after
             * every appearance of the word in the string.
             * Ignore cases where there is no char before or after the word,
             * and a char may be included twice if it is between two words.
             *
             * wordEnds("abcXY123XYijk", "XY") → "c13i"
             * wordEnds("XY123XY", "XY") → "13"
             * wordEnds("XY1XY", "XY") → "11"
             */
            Console.WriteLine(WordEnds("abcXY123XYijk", "XY"));
            Console.WriteLine(WordEnds("XY123XY", "XY"));
            Console.WriteLine(WordEnds("XY1XY", "XY"));
        }

        private static string WordEnds(string str, string word)
        {
            if (!str.Contains(word)) return str;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= str.Length - word.Length; i++)
            {
                if (i > 0 && str.Substring(i).StartsWith(word)) { sb.Append(str[i - 1]); }
                if (i < str.Length - word.Length && str.Substring(i).StartsWith(word)) { sb.Append(str[i + word.Length]); }
            }
            return sb.ToString();
        }
    }
}

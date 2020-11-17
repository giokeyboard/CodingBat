using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a second "word" string, we'll say that the word matches the string if
             * it appears at the front of the string, except its first char does not need to match exactly.
             * On a match, return the front of the string, or otherwise return the empty string.
             * So, so with the string "hippo" the word "hi" returns "hi" and "xip" returns "hip".
             * The word will be at least length 1.
             *
             * startWord("hippo", "hi") → "hi"
             * startWord("hippo", "xip") → "hip"
             * startWord("hippo", "i") → "h"
             */
            Console.WriteLine(StartWord("hippo", "hi"));
            Console.WriteLine(StartWord("hippo", "xip"));
            Console.WriteLine(StartWord("hippo", "i"));
        }

        private static string StartWord(string str, string word)
        {
            if (str.Length > 0 && str.Substring(1).StartsWith(word.Substring(1)))
            {
                return (str.Length < word.Length) ? str : str.Substring(0, word.Length);
            }
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of strings, return the count of the number of strings with the given length.
             *
             * wordsCount(["a", "bb", "b", "ccc"], 1) → 2
             * wordsCount(["a", "bb", "b", "ccc"], 3) → 1
             * wordsCount(["a", "bb", "b", "ccc"], 4) → 0
             */
            Console.WriteLine(WordsCount(new String[] { "a", "bb", "b", "ccc" }, 1));
            Console.WriteLine(WordsCount(new String[] { "a", "bb", "b", "ccc" }, 3));
            Console.WriteLine(WordsCount(new String[] { "a", "bb", "b", "ccc" }, 4));
        }

        private static int WordsCount(string[] words, int len)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == len) count++;
            }
            return count;
        }
    }
}

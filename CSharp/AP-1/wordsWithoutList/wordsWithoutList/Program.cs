using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordsWithoutList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of strings, return a new List (e.g. an ArrayList) where
             * all the strings of the given length are omitted.
             * See wordsWithout() below which is more difficult because it uses arrays.
             *
             * wordsWithoutList(["a", "bb", "b", "ccc"], 1) → ["bb", "ccc"]
             * wordsWithoutList(["a", "bb", "b", "ccc"], 3) → ["a", "bb", "b"]
             * wordsWithoutList(["a", "bb", "b", "ccc"], 4) → ["a", "bb", "b", "ccc"]
             */
            Console.WriteLine($"[{String.Join(",", WordsWithoutList(new String[] { "a", "bb", "b", "ccc" }, 1))}]");
            Console.WriteLine($"[{String.Join(",", WordsWithoutList(new String[] { "a", "bb", "b", "ccc" }, 3))}]");
            Console.WriteLine($"[{String.Join(",", WordsWithoutList(new String[] { "a", "bb", "b", "ccc" }, 4))}]");
        }

        private static IList<string> WordsWithoutList(string[] words, int len)
        {
            IList<string> output = new List<string>();
            foreach (string word in words)
            {
                if (word.Length != len) output.Add(word);
            }
            return output;
        }
    }
}

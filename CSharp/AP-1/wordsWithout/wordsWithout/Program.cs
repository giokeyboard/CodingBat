using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordsWithout
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of strings, return a new array without the strings that are equal to the target string.
             * One approach is to count the occurrences of the target string, make a new array of the correct length,
             * and then copy over the correct strings.
             *
             * wordsWithout(["a", "b", "c", "a"], "a") → ["b", "c"]
             * wordsWithout(["a", "b", "c", "a"], "b") → ["a", "c", "a"]
             * wordsWithout(["a", "b", "c", "a"], "c") → ["a", "b", "a"]
             */
            Console.WriteLine($"[{String.Join(",", WordsWithout(new String[] { "a", "b", "c", "a" }, "a"))}]");
            Console.WriteLine($"[{String.Join(",", WordsWithout(new String[] { "a", "b", "c", "a" }, "b"))}]");
            Console.WriteLine($"[{String.Join(",", WordsWithout(new String[] { "a", "b", "c", "a" }, "c"))}]");
        }

        private static String[] WordsWithout(string[] words, string target)
        {
            return words.Where(x => !x.Equals(target)).ToList().ToArray();
        }
    }
}

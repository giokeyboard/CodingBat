using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings, word and a separator sep, return a big string made of count occurrences of the word,
             * separated by the separator string.
             *
             * repeatSeparator("Word", "X", 3) → "WordXWordXWord"
             * repeatSeparator("This", "And", 2) → "ThisAndThis"
             * repeatSeparator("This", "And", 1) → "This"
             */
            Console.WriteLine(RepeatSeparator("Word", "X", 3));
            Console.WriteLine(RepeatSeparator("This", "And", 2));
            Console.WriteLine(RepeatSeparator("This", "And", 1));
        }

        private static string RepeatSeparator(string word, string sep, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append((i == count - 1) ? word : word + sep);
            }
            return sb.ToString();
        }
    }
}

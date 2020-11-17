using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeOutWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an "out" string length 4, such as "<<>>", and a word, return a new string where
             * the word is in the middle of the out string, e.g. "<<word>>".
             * Note: use str.substring(i, j) to extract the String starting at index i and going up to but not including index j.
             *
             * makeOutWord("<<>>", "Yay") → "<<Yay>>"
             * makeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"
             * makeOutWord("[[]]", "word") → "[[word]]"
             */
            Console.WriteLine(MakeOutWord("<<>>", "Yay"));
            Console.WriteLine(MakeOutWord("<<>>", "WooHoo"));
            Console.WriteLine(MakeOutWord("[[]]", "word"));
        }

        private static string MakeOutWord(string outp, string word)
        {
            return $"{outp.Substring(0,2)}{word}{outp.Substring(2, 2)}";
        }
    }
}

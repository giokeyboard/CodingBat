using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plusOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a non-empty word string, return a version of the original String where all chars
             * have been replaced by pluses ("+"), except for appearances of the word string which are preserved unchanged.
             *
             * plusOut("12xy34", "xy") → "++xy++"
             * plusOut("12xy34", "1") → "1+++++"
             * plusOut("12xy34xyabcxy", "xy") → "++xy++xy+++xy"
             */
            Console.WriteLine(PlusOut("12xy34", "xy"));
            Console.WriteLine(PlusOut("12xy34", "1"));
            Console.WriteLine(PlusOut("12xy34xyabcxy", "xy"));
        }

        private static string PlusOut(string str, string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (!str.Substring(i).StartsWith(word)) sb.Append('+');
                else
                {
                    sb.Append(word);
                    i += word.Length - 1;
                }
            }
            return sb.ToString();
        }
    }
}

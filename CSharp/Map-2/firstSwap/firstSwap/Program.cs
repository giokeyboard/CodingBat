using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that 2 strings "match" if they are non-empty and their first chars are the same.
             * Loop over and then return the given array of non-empty strings as follows:
             * if a string matches an earlier string in the array, swap the 2 strings in the array.
             * A particular first char can only cause 1 swap, so once a char has caused a swap, its later swaps are disabled.
             * Using a map, this can be solved making just one pass over the array. More difficult than it looks.
             *
             * firstSwap(["ab", "ac"]) → ["ac", "ab"]
             * firstSwap(["ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz"]) → ["ay", "by", "cy", "cx", "bx", "ax", "aaa", "azz"]
             * firstSwap(["ax", "bx", "ay", "by", "ai", "aj", "bx", "by"]) → ["ay", "by", "ax", "bx", "ai", "aj", "bx", "by"]
             */
            Console.WriteLine($"[{String.Join(",", FirstSwap(new String[] { "ab", "ac" }))}]");
            Console.WriteLine($"[{String.Join(",", FirstSwap(new String[] { "ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz" }))}]");
            Console.WriteLine($"[{String.Join(",", FirstSwap(new String[] { "ax", "bx", "ay", "by", "ai", "aj", "bx", "by" }))}]");
        }

        private static string[] FirstSwap(string[] strings)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                char c = strings[i][0];
                if (map.ContainsKey(c))
                {
                    if (map[c] >= 0)
                    {
                        string temp = strings[map[c]];
                        strings[map[c]] = strings[i];
                        strings[i] = temp;
                        map[c] = -1;    // swap disabled
                    }
                    else continue;
                }
                else map[c] = i;
            }
            return strings;
        }
    }
}

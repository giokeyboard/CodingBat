using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that 2 strings "match" if they are non-empty and their first chars are the same.
             * Loop over and then return the given array of non-empty strings as follows:
             * if a string matches an earlier string in the array, swap the 2 strings in the array.
             * When a position in the array has been swapped, it no longer matches anything.
             * Using a map, this can be solved making just one pass over the array. More difficult than it looks.
             *
             * allSwap(["ab", "ac"]) → ["ac", "ab"]
             * allSwap(["ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz"]) → ["ay", "by", "cy", "cx", "bx", "ax", "azz", "aaa"]
             * allSwap(["ax", "bx", "ay", "by", "ai", "aj", "bx", "by"]) → ["ay", "by", "ax", "bx", "aj", "ai", "by", "bx"]
             */
            Console.WriteLine($"[{String.Join(",", AllSwap(new String[] { "ab", "ac" }))}]");
            Console.WriteLine($"[{String.Join(",", AllSwap(new String[] { "ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz" }))}]");
            Console.WriteLine($"[{String.Join(",", AllSwap(new String[] { "ax", "bx", "ay", "by", "ai", "aj", "bx", "by" }))}]");
        }

        private static string[] AllSwap(string[] strings)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (map.ContainsKey(strings[i][0]))
                {
                    string temp = strings[map[strings[i][0]]];
                    strings[map[strings[i][0]]] = strings[i];
                    strings[i] = temp;
                    map.Remove(strings[i][0]);
                }
                else map[strings[i][0]] = i;
            }
            return strings;
        }
    }
}

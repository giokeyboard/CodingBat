using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of non-empty strings, return a Map<String, String> with a key for every different first
             * character seen, with the value of all the strings starting with that character appended together in the
             * order they appear in the array.
             *
             * firstChar(["salt", "tea", "soda", "toast"]) → {"s": "saltsoda", "t": "teatoast"}
             * firstChar(["aa", "bb", "cc", "aAA", "cCC", "d"]) → {"a": "aaaAA", "b": "bb", "c": "cccCC", "d": "d"}
             * firstChar([]) → {}
             */
            FirstChar(new String[] { "salt", "tea", "soda", "toast" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            FirstChar(new String[] { "aa", "bb", "cc", "aAA", "cCC", "d" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            FirstChar(new String[] { }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
        }

        private static Dictionary<string, string> FirstChar(string[] strings)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            foreach (string s in strings)
            {
                if (map.ContainsKey(s.Substring(0, 1))) map[s.Substring(0, 1)] += s;
                else map[s.Substring(0, 1)] = s;
            }
            return map;
        }
    }
}

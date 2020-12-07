using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of strings, return a Map<String, Boolean> where each different string is a key and
             * its value is true if that string appears 2 or more times in the array.
             *
             * wordMultiple(["a", "b", "a", "c", "b"]) → {"a": true, "b": true, "c": false}
             * wordMultiple(["c", "b", "a"]) → {"a": false, "b": false, "c": false}
             * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
             */
            WordMultiple(new String[] { "a", "b", "a", "c", "b" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            WordMultiple(new String[] { "c", "b", "a" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            WordMultiple(new String[] { "c", "c", "c", "c" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
        }

        private static Dictionary<string, bool> WordMultiple(string[] strings)
        {
            Dictionary<string, bool> map = new Dictionary<string, bool>();
            foreach (string s in strings)
            {
                map[s] = map.ContainsKey(s);
            }
            return map;
        }
    }
}

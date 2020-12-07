using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The classic word-count algorithm: given an array of strings, return a Map<String, Integer> with a key for
             * each different string, with the value the number of times that string appears in the array.
             *
             * wordCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
             * wordCount(["c", "b", "a"]) → {"a": 1, "b": 1, "c": 1}
             * wordCount(["c", "c", "c", "c"]) → {"c": 4}
             */
            WordCount(new String[] { "a", "b", "a", "c", "b" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            WordCount(new String[] { "c", "b", "a" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            WordCount(new String[] { "c", "c", "c", "c" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
        }

        private static Dictionary<string, int> WordCount(string[] strings)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string s in strings)
            {
                if (map.ContainsKey(s)) map[s]++;
                else map[s] = 1;
            }
            return map;
        }
    }
}

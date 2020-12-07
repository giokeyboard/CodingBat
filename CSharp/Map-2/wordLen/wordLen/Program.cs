using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordLen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of strings, return a Map<String, Integer> containing a key for every different string
             * in the array, and the value is that string's length.
             *
             * wordLen(["a", "bb", "a", "bb"]) → {"bb": 2, "a": 1}
             * wordLen(["this", "and", "that", "and"]) → {"that": 4, "and": 3, "this": 4}
             * wordLen(["code", "code", "code", "bug"]) → {"code": 4, "bug": 3}
             */
            WordLen(new string[] { "a", "bb", "a", "bb" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            WordLen(new string[] { "this", "and", "that", "and" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            WordLen(new string[] { "code", "code", "code", "bug" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        private static Dictionary<string, int> WordLen(string[] strings)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string s in strings)
            {
                map[s] = s.Length;
            }
            return map;
        }
    }
}

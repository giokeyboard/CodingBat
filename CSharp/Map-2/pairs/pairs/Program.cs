using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of non-empty strings, create and return a Map<String, String> as follows:
             * for each string add its first character as a key with its last character as the value.
             *
             * pairs(["code", "bug"]) → {"b": "g", "c": "e"}
             * pairs(["man", "moon", "main"]) → {"m": "n"}
             * pairs(["man", "moon", "good", "night"]) → {"g": "d", "m": "n", "n": "t"}
             */
            Pairs(new String[] { "code", "bug" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            Pairs(new String[] { "man", "moon", "main" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            Pairs(new String[] { "man", "moon", "good", "night" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        private static Dictionary<string, string> Pairs(string[] strings)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            foreach (string s in strings)
            {
                map[s.Substring(0, 1)] = s.Substring(s.Length - 1);
            }
            return map;
        }
    }
}

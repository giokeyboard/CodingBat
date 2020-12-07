using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of strings, return a Map<String, Integer> containing a key for every different string
             * in the array, always with the value 0. For example the string "hello" makes the pair "hello":0.
             * We'll do more complicated counting later, but for this problem the value is simply 0.
             *
             * word0(["a", "b", "a", "b"]) → {"a": 0, "b": 0}
             * word0(["a", "b", "a", "c", "b"]) → {"a": 0, "b": 0, "c": 0}
             * word0(["c", "b", "a"]) → {"a": 0, "b": 0, "c": 0}
             */
            Word0(new String[] { "a", "b", "a", "b" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            Word0(new String[] { "a", "b", "a", "c", "b" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
            Word0(new String[] { "c", "b", "a" }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        static Dictionary<string, int> Word0(string[] strings)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string s in strings)
            {
                map[s] = 0;
            }
            return map;
        }
    }
}

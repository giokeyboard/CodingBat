using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordsFront
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of strings,
             * return a new array containing the first N strings. N will be in the range 1..length.
             *
             * wordsFront(["a", "b", "c", "d"], 1) → ["a"]
             * wordsFront(["a", "b", "c", "d"], 2) → ["a", "b"]
             * wordsFront(["a", "b", "c", "d"], 3) → ["a", "b", "c"]
             */
            Console.WriteLine($"[{String.Join(",", WordsFront(new String[] { "a", "b", "c", "d" }, 1))}]");
            Console.WriteLine($"[{String.Join(",", WordsFront(new String[] { "a", "b", "c", "d" }, 2))}]");
            Console.WriteLine($"[{String.Join(",", WordsFront(new String[] { "a", "b", "c", "d" }, 3))}]");
        }

        private static string[] WordsFront(string[] words, int n)
        {
            //string[] output = new string[n];
            //for (int i = 0; i < output.Length; i++)
            //{
            //    output[i] = words[i];
            //}
            //return output;

            return words.Take(n).ToArray();
        }
    }
}

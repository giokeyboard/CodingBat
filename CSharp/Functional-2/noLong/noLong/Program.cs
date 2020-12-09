using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noLong
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list of the strings, omitting any string length 4 or more.
             *
             * noLong(["this", "not", "too", "long"]) → ["not", "too"]
             * noLong(["a", "bbb", "cccc"]) → ["a", "bbb"]
             * noLong(["cccc", "cccc", "cccc"]) → []
             */
            Console.WriteLine($"[{String.Join(",", noLong(new List<string>(new string[] { "this", "not", "too", "long" })))}]");
            Console.WriteLine($"[{String.Join(",", noLong(new List<string>(new string[] { "a", "bbb", "cccc" })))}]");
            Console.WriteLine($"[{String.Join(",", noLong(new List<string>(new string[] { "cccc", "cccc", "cccc" })))}]");
        }

        private static List<string> noLong(List<string> strings)
        {
            return strings.Where(x => x.Length < 4).ToList();
        }
    }
}

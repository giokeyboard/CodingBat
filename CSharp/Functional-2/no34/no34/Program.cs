using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no34
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list of the strings, omitting any string length 3 or 4.
             *
             * no34(["a", "bb", "ccc"]) → ["a", "bb"]
             * no34(["a", "bb", "ccc", "dddd"]) → ["a", "bb"]
             * no34(["ccc", "dddd", "apple"]) → ["apple"]
             */
            Console.WriteLine($"[{String.Join(",", No34(new List<string>(new string[] { "a", "bb", "ccc" })))}]");
            Console.WriteLine($"[{String.Join(",", No34(new List<string>(new string[] { "a", "bb", "ccc", "dddd" })))}]");
            Console.WriteLine($"[{String.Join(",", No34(new List<string>(new string[] { "ccc", "dddd", "apple" })))}]");
        }

        private static List<string> No34(List<string> strings)
        {
            return strings.Where(x => x.Length != 3 && x.Length != 4).ToList();
        }
    }
}

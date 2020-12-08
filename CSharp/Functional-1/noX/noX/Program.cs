using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list where each string has all its "x" removed.
             *
             * noX(["ax", "bb", "cx"]) → ["a", "bb", "c"]
             * noX(["xxax", "xbxbx", "xxcx"]) → ["a", "bb", "c"]
             * noX(["x"]) → [""]
             */
            Console.WriteLine($"[{String.Join(",", NoX(new List<string>(new string[] { "ax", "bb", "cx" })))}]");
            Console.WriteLine($"[{String.Join(",", NoX(new List<string>(new string[] { "xxax", "xbxbx", "xxcx" })))}]");
            Console.WriteLine($"[{String.Join(",", NoX(new List<string>(new string[] { "x" })))}]");
        }

        private static List<string> NoX(List<string> strings)
        {
            return strings.Select(s => s.Replace("x", "")).ToList();
        }
    }
}

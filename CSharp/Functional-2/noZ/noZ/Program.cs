using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noZ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list of the strings, omitting any string that contains a "z".
             * (Note: the str.contains(x) method returns a boolean)
             *
             * noZ(["aaa", "bbb", "aza"]) → ["aaa", "bbb"]
             * noZ(["hziz", "hzello", "hi"]) → ["hi"]
             * noZ(["hello", "howz", "are", "youz"]) → ["hello", "are"]
             */
            Console.WriteLine($"[{String.Join(",", noZ(new List<string>(new string[] { "aaa", "bbb", "aza" })))}]");
            Console.WriteLine($"[{String.Join(",", noZ(new List<string>(new string[] { "hziz", "hzello", "hi" })))}]");
            Console.WriteLine($"[{String.Join(",", noZ(new List<string>(new string[] { "hello", "howz", "are", "youz" })))}]");
        }

        private static List<string> noZ(List<string> strings)
        {
            return strings.Where(x => !x.Contains("z")).ToList();
        }
    }
}

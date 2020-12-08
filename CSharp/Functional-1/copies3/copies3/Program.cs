using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copies3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list where each string is replaced by 3 copies of the string
             * concatenated together.
             *
             * copies3(["a", "bb", "ccc"]) → ["aaa", "bbbbbb", "ccccccccc"]
             * copies3(["24", "a", ""]) → ["242424", "aaa", ""]
             * copies3(["hello", "there"]) → ["hellohellohello", "theretherethere"]
             */
            Console.WriteLine($"[{String.Join(",", copies3(new List<string>(new string[] { "a", "bb", "ccc" })))}]");
            Console.WriteLine($"[{String.Join(",", copies3(new List<string>(new string[] { "24", "a", "" })))}]");
            Console.WriteLine($"[{String.Join(",", copies3(new List<string>(new string[] { "hello", "there" })))}]");
        }

        private static List<string> copies3(List<string> strings)
        {
            return strings.Select(s => s + s + s).ToList();
        }
    }
}

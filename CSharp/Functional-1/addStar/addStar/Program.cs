using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addStar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list where each string has "*" added at its end.
             *
             * addStar(["a", "bb", "ccc"]) → ["a*", "bb*", "ccc*"]
             * addStar(["hello", "there"]) → ["hello*", "there*"]
             * addStar(["*"]) → ["**"]
             */
            Console.WriteLine($"[{String.Join(",", AddStar(new List<string>(new string[] { "a", "bb", "ccc" })))}]");
            Console.WriteLine($"[{String.Join(",", AddStar(new List<string>(new string[] { "hello", "there" })))}]");
            Console.WriteLine($"[{String.Join(",", AddStar(new List<string>(new string[] { "*" })))}]");
        }

        private static List<string> AddStar(List<string> strings)
        {
            return strings.Select(s => s + '*').ToList();
        }
    }
}

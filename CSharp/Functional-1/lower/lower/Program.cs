using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lower
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list where each string is converted to lower case
             * (Note: String toLowerCase() method).
             *
             * lower(["Hello", "Hi"]) → ["hello", "hi"]
             * lower(["AAA", "BBB", "ccc"]) → ["aaa", "bbb", "ccc"]
             * lower(["KitteN", "ChocolaTE"]) → ["kitten", "chocolate"]
             */
            Console.WriteLine($"[{String.Join(",", Lower(new List<string>(new string[] { "Hello", "Hi" })))}]");
            Console.WriteLine($"[{String.Join(",", Lower(new List<string>(new string[] { "AAA", "BBB", "ccc" })))}]");
            Console.WriteLine($"[{String.Join(",", Lower(new List<string>(new string[] { "KitteN", "ChocolaTE" })))}]");
        }

        private static List<string> Lower(List<string> strings)
        {
            return strings.Select(s => s.ToLower()).ToList();
        }
    }
}

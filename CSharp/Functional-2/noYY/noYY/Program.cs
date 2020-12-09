using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noYY
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list where each string has "y" added at its end,
             * omitting any resulting strings that contain "yy" as a substring anywhere.
             *
             * noYY(["a", "b", "c"]) → ["ay", "by", "cy"]
             * noYY(["a", "b", "cy"]) → ["ay", "by"]
             * noYY(["xx", "ya", "zz"]) → ["xxy", "yay", "zzy"]
             */
            Console.WriteLine($"[{String.Join(",", NoYY(new List<string>(new string[] { "a", "b", "c" })))}]");
            Console.WriteLine($"[{String.Join(",", NoYY(new List<string>(new string[] { "a", "b", "cy" })))}]");
            Console.WriteLine($"[{String.Join(",", NoYY(new List<string>(new string[] { "xx", "ya", "zz" })))}]");
        }

        private static List<string> NoYY(List<string> strings)
        {
            return strings.Select(x => x + "y").Where(x => !x.Contains("yy")).ToList();
        }
    }
}

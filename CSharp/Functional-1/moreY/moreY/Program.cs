using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreY
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of strings, return a list where each string has "y" added at its start and end.
             *
             * moreY(["a", "b", "c"]) → ["yay", "yby", "ycy"]
             * moreY(["hello", "there"]) → ["yhelloy", "ytherey"]
             * moreY(["yay"]) → ["yyayy"]
             */
            Console.WriteLine($"[{String.Join(",", MoreY(new List<string>(new string[] { "a", "b", "c" })))}]");
            Console.WriteLine($"[{String.Join(",", MoreY(new List<string>(new string[] { "hello", "there" })))}]");
            Console.WriteLine($"[{String.Join(",", MoreY(new List<string>(new string[] { "yay" })))}]");
        }

        private static List<string> MoreY(List<string> strings)
        {
            return strings.Select(s => 'y' + s + 'y').ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countHi2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively the number of times lowercase "hi" appears in the string,
             * however do not count "hi" that have an 'x' immediately before them.
             *
             * countHi2("ahixhi") → 1
             * countHi2("ahibhi") → 2
             * countHi2("xhixhi") → 0
             */
            Console.WriteLine(CountHi2("ahixhi"));
            Console.WriteLine(CountHi2("ahibhi"));
            Console.WriteLine(CountHi2("xhixhi"));
        }

        private static int CountHi2(string str)
        {
            if (str.Length < 2) return 0;
            if (str.StartsWith("xhi")) return CountHi2(str.Substring(3));
            if (str.StartsWith("hi")) return 1 + CountHi2(str.Substring(2));
            return CountHi2(str.Substring(1));
        }
    }
}

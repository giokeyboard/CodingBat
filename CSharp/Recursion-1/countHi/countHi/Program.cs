using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countHi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively (no loops) the number of times lowercase "hi" appears in the string.
             *
             * countHi("xxhixx") → 1
             * countHi("xhixhix") → 2
             * countHi("hi") → 1
             */
            Console.WriteLine(CountHi("xxhixx"));
            Console.WriteLine(CountHi("xhixhix"));
            Console.WriteLine(CountHi("hi"));
        }

        private static int CountHi(string str)
        {
            if (str.Length < 2) return 0;
            if (str.StartsWith("hi")) return 1 + CountHi(str.Substring(1));
            return CountHi(str.Substring(1));
        }
    }
}

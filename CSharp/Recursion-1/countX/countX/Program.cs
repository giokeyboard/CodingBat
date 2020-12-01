using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively (no loops) the number of lowercase 'x' chars in the string.
             *
             * countX("xxhixx") → 4
             * countX("xhixhix") → 3
             * countX("hi") → 0
             */
            Console.WriteLine(CountX("xxhixx"));
            Console.WriteLine(CountX("xhixhix"));
            Console.WriteLine(CountX("hi"));
        }

        private static int CountX(string str)
        {
            if (str.Length == 0) return 0;
            if (str[0] == 'x') return 1 + CountX(str.Substring(1));
            return CountX(str.Substring(1));
        }
    }
}

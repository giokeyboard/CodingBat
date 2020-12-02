using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countAbc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Count recursively the total number of "abc" and "aba" substrings that appear in the given string.
             *
             * countAbc("abc") → 1
             * countAbc("abcxxabc") → 2
             * countAbc("abaxxaba") → 2
             */
            Console.WriteLine(CountAbc("abc"));
            Console.WriteLine(CountAbc("abcxxabc"));
            Console.WriteLine(CountAbc("abaxxaba"));
        }

        private static int CountAbc(string str)
        {
            if (str.Length < 3) return 0;
            if (str.StartsWith("abc") || str.StartsWith("aba")) return 1 + CountAbc(str.Substring(1));
            return CountAbc(str.Substring(1));
        }
    }
}

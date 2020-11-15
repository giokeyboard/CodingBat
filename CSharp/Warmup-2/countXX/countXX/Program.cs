using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countXX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".
             *
             * countXX("abcxx") → 1
             * countXX("xxx") → 2
             * countXX("xxxx") → 3
             */
            Console.WriteLine(CountXX("abcxx"));
            Console.WriteLine(CountXX("xxx"));
            Console.WriteLine(CountXX("xxxx"));
        }

        private static int CountXX(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2).Equals("xx")) { count++; }
            }
            return count;
        }
    }
}

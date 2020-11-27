using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return the length of the largest "block" in the string.
             * A block is a run of adjacent chars that are the same.
             *
             * maxBlock("hoopla") → 2
             * maxBlock("abbCCCddBBBxx") → 3
             * maxBlock("") → 0
             */
            Console.WriteLine(MaxBlock("hoopla"));
            Console.WriteLine(MaxBlock("abbCCCddBBBxx"));
            Console.WriteLine(MaxBlock(""));
        }

        private static int MaxBlock(string str)
        {
            if (str.Length < 1) return 0;

            int max = 0;
            int count = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1]) count++;
                else count = 1;
                max = Math.Max(max, count);
            }
            return max;
        }
    }
}

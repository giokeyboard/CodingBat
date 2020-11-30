using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesUp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given n>=0, create an array with the pattern {1,    1, 2,    1, 2, 3,   ... 1, 2, 3 .. n}
             * (spaces added to show the grouping). Note that the length of the array will be 1 + 2 + 3 ... + n,
             * which is known to sum to exactly n*(n + 1)/2.
             *
             * seriesUp(3) → [1, 1, 2, 1, 2, 3]
             * seriesUp(4) → [1, 1, 2, 1, 2, 3, 1, 2, 3, 4]
             * seriesUp(2) → [1, 1, 2]
             */
            Console.WriteLine($"[{String.Join(",", SeriesUp(3))}]");
            Console.WriteLine($"[{String.Join(",", SeriesUp(4))}]");
            Console.WriteLine($"[{String.Join(",", SeriesUp(2))}]");
        }

        private static int[] SeriesUp(int n)
        {
            if (n == 0) return new int[] { };

            int[] output = new int[n * (n + 1) / 2];
            int index = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    output[j + index] = j+1;
                }
                index += i;
            }

            return output;
        }
    }
}

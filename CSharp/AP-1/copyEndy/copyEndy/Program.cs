using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyEndy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a positive int n is "endy" if it is in the range 0..10 or 90..100 (inclusive).
             * Given an array of positive ints, return a new array of length "count" containing the first
             * endy numbers from the original array. Decompose out a separate isEndy(int n) method to test
             * if a number is endy. The original array will contain at least "count" endy numbers.
             *
             * copyEndy([9, 11, 90, 22, 6], 2) → [9, 90]
             * copyEndy([9, 11, 90, 22, 6], 3) → [9, 90, 6]
             * copyEndy([12, 1, 1, 13, 0, 20], 2) → [1, 1]
             */
            Console.WriteLine($"[{String.Join(",", CopyEndy(new int[] { 9, 11, 90, 22, 6 }, 2))}]");
            Console.WriteLine($"[{String.Join(",", CopyEndy(new int[] { 9, 11, 90, 22, 6 }, 3))}]");
            Console.WriteLine($"[{String.Join(",", CopyEndy(new int[] { 12, 1, 1, 13, 0, 20 }, 2))}]");
        }

        private static int[] CopyEndy(int[] nums, int count)
        {
            int[] output = new int[count];
            int i = 0;
            foreach (int num in nums)
            {
                if (i < count && isEndy(num)) output[i++] = num;
            }
            return output;
        }

        private static bool isEndy(int n)
        {
            return (n >= 0 && n <= 10) || (n >= 90 && n <= 100);
        }
    }
}

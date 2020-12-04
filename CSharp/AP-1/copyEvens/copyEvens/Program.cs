using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given an array of positive ints, return a new array of length "count" containing the first even numbers
            * from the original array. The original array will contain at least "count" even numbers.
            *
            * copyEvens([3, 2, 4, 5, 8], 2) → [2, 4]
            * copyEvens([3, 2, 4, 5, 8], 3) → [2, 4, 8]
            * copyEvens([6, 1, 2, 4, 5, 8], 3) → [6, 2, 4]
            */
            Console.WriteLine($"[{String.Join(",", CopyEvens(new int[] { 3, 2, 4, 5, 8 }, 2))}]");
            Console.WriteLine($"[{String.Join(",", CopyEvens(new int[] { 3, 2, 4, 5, 8 }, 3))}]");
            Console.WriteLine($"[{String.Join(",", CopyEvens(new int[] { 6, 1, 2, 4, 5, 8 }, 3))}]");
        }

        private static int[] CopyEvens(int[] nums, int count)
        {
            int[] output = new int[count];
            int index = 0;
            foreach (int num in nums)
            {
                if (index < count && num % 2 == 0) output[index++] = num;
            }
            return output;
        }
    }
}

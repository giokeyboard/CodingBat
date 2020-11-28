using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Consider the leftmost and rightmost appearances of some value in an array.
             * We'll say that the "span" is the number of elements between the two inclusive.
             * A single value has a span of 1. Returns the largest span found in the given array. (Efficiency is not a priority.)
             *
             * maxSpan([1, 2, 1, 1, 3]) → 4
             * maxSpan([1, 4, 2, 1, 4, 1, 4]) → 6
             * maxSpan([1, 4, 2, 1, 4, 4, 4]) → 6
             */
            Console.WriteLine(MaxSpan(new int[] { 1, 2, 1, 1, 3 }));
            Console.WriteLine(MaxSpan(new int[] { 1, 4, 2, 1, 4, 1, 4 }));
            Console.WriteLine(MaxSpan(new int[] { 1, 4, 2, 1, 4, 4, 4 }));
            Console.WriteLine(MaxSpan(new int[] { 1 }));
            Console.WriteLine(MaxSpan(new int[] { }));
        }

        private static int MaxSpan(int[] nums)
        {
            int span = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j >= i; j--)
                {
                    if (nums[i] == nums[j]) span = Math.Max(span, j + 1 - i);
                }
            }
            return span;
        }
    }
}

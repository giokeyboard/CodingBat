using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitOdd10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, is it possible to divide the ints into two groups,
             * so that the sum of one group is a multiple of 10, and the sum of the other group is odd.
             * Every int must be in one group or the other.
             * Write a recursive helper method that takes whatever arguments you like, and make the initial call to
             * your recursive helper from splitOdd10(). (No loops needed.)
             *
             * splitOdd10([5, 5, 5]) → true
             * splitOdd10([5, 5, 6]) → false
             * splitOdd10([5, 5, 6, 1]) → true
             */
            Console.WriteLine(SplitOdd10(new int[] { 5, 5, 5 }));
            Console.WriteLine(SplitOdd10(new int[] { 5, 5, 6 }));
            Console.WriteLine(SplitOdd10(new int[] { 5, 5, 6, 1 }));
        }

        private static bool SplitOdd10(int[] nums)
        {
            return SplitHelper(nums, 0, 0, 0);
        }

        private static bool SplitHelper(int[] nums, int i, int sum1, int sum2)
        {
            if (i == nums.Length) return sum1 % 10 == 0 && sum2 % 2 == 1;
            return SplitHelper(nums, i + 1, sum1 + nums[i], sum2) || SplitHelper(nums, i + 1, sum1, sum2 + nums[i]);
        }
    }
}

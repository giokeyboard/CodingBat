using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, is it possible to divide the ints into two groups,
             * so that the sums of the two groups are the same. Every int must be in one group or the other.
             * Write a recursive helper method that takes whatever arguments you like, and make the initial call
             * to your recursive helper from splitArray(). (No loops needed.)
             *
             * splitArray([2, 2]) → true
             * splitArray([2, 3]) → false
             * splitArray([5, 2, 3]) → true
             */
            Console.WriteLine(SplitArray(new int[] { 2, 2 }));
            Console.WriteLine(SplitArray(new int[] { 2, 3 }));
            Console.WriteLine(SplitArray(new int[] { 5, 2, 3 }));
        }

        private static bool SplitArray(int[] nums)
        {
            return SplitArrayHelper(nums, 0, 0, 0);
        }

        private static bool SplitArrayHelper(int[] nums, int i, int sum1, int sum2)
        {
            if (i == nums.Length) return sum1 == sum2;
            return SplitArrayHelper(nums, i + 1, sum1 + nums[i], sum2) || SplitArrayHelper(nums, i + 1, sum1, sum2 + nums[i]);
        }
    }
}

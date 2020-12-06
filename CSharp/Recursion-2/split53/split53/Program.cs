using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split53
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, is it possible to divide the ints into two groups,
             * so that the sum of the two groups is the same, with these constraints:
             * all the values that are multiple of 5 must be in one group,
             * and all the values that are a multiple of 3 (and not a multiple of 5) must be in the other.
             * (No loops needed.)
             *
             * split53([1, 1]) → true
             * split53([1, 1, 1]) → false
             * split53([2, 4, 2]) → true
             */
            Console.WriteLine(Split53(new int[] { 1, 1 }));
            Console.WriteLine(Split53(new int[] { 1, 1, 1 }));
            Console.WriteLine(Split53(new int[] { 2, 4, 2 }));
        }

        private static bool Split53(int[] nums)
        {
            return SplitHelper(nums, 0, 0, 0);
        }

        private static bool SplitHelper(int[] nums, int i, int sum3, int sum5)
        {
            if (i == nums.Length) return sum3 == sum5;
            if (nums[i] % 3 == 0) return SplitHelper(nums, i + 1, sum3 + nums[i], sum5);
            if (nums[i] % 5 == 0) return SplitHelper(nums, i + 1, sum3, sum5 + nums[i]);
            return SplitHelper(nums, i + 1, sum3 + nums[i], sum5) || SplitHelper(nums, i + 1, sum3, sum5 + nums[i]);
        }
    }
}

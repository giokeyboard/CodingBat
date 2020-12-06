using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupSum5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, is it possible to choose a group of some of the ints, such that the group sums
             * to the given target with these additional constraints: all multiples of 5 in the array must be included
             * in the group. If the value immediately following a multiple of 5 is 1, it must not be chosen.
             * (No loops needed.)
             *
             * groupSum5(0, [2, 5, 10, 4], 19) → true
             * groupSum5(0, [2, 5, 10, 4], 17) → true
             * groupSum5(0, [2, 5, 10, 4], 12) → false
             */
            Console.WriteLine(GroupSum5(0, new int[] { 2, 5, 10, 4 }, 19));
            Console.WriteLine(GroupSum5(0, new int[] { 2, 5, 10, 4 }, 17));
            Console.WriteLine(GroupSum5(0, new int[] { 2, 5, 10, 4 }, 12));
        }

        private static bool GroupSum5(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            if (nums[start] % 5 == 0)
            {
                if (start < nums.Length - 1 && nums[start + 1] == 1) return GroupSum5(start + 2, nums, target - nums[start]);
                return GroupSum5(start + 1, nums, target - nums[start]);
            }
            if (GroupSum5(start + 1, nums, target - nums[start])) return true;
            return GroupSum5(start + 1, nums, target);
        }
    }
}

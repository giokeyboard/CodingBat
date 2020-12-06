using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupSum6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, is it possible to choose a group of some of the ints, beginning at the start index,
             * such that the group sums to the given target? However, with the additional constraint that all 6's must be
             * chosen. (No loops needed.)
             *
             * groupSum6(0, [5, 6, 2], 8) → true
             * groupSum6(0, [5, 6, 2], 9) → false
             * groupSum6(0, [5, 6, 2], 7) → false
             */
            Console.WriteLine(GroupSum6(0, new int[] { 5, 6, 2 }, 8));
            Console.WriteLine(GroupSum6(0, new int[] { 5, 6, 2 }, 9));
            Console.WriteLine(GroupSum6(0, new int[] { 5, 6, 2 }, 7));
        }

        private static bool GroupSum6(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            if (nums[start] == 6) return GroupSum6(start + 1, nums, target - nums[start]);
            if (GroupSum6(start + 1, nums, target - nums[start])) return true;
            return GroupSum6(start + 1, nums, target);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupSumClump
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, is it possible to choose a group of some of the ints,
             * such that the group sums to the given target, with this additional constraint:
             * if there are numbers in the array that are adjacent and the identical value, they must either all be chosen,
             * or none of them chosen. For example, with the array {1, 2, 2, 2, 5, 2},
             * either all three 2's in the middle must be chosen or not, all as a group.
             * (one loop can be used to find the extent of the identical values).
             *
             * groupSumClump(0, [2, 4, 8], 10) → true
             * groupSumClump(0, [1, 2, 4, 8, 1], 14) → true
             * groupSumClump(0, [2, 4, 4, 8], 14) → false
             */
            Console.WriteLine(GroupSumClump(0, new int[] { 2, 4, 8 }, 10));
            Console.WriteLine(GroupSumClump(0, new int[] { 1, 2, 4, 8, 1 }, 14));
            Console.WriteLine(GroupSumClump(0, new int[] { 2, 4, 4, 8 }, 14));
            Console.WriteLine(GroupSumClump(0, new int[] { 8, 2, 2, 1 }, 9));
            Console.WriteLine(GroupSumClump(0, new int[] { 8, 2, 2, 1 }, 11));
            Console.WriteLine(GroupSumClump(0, new int[] { 1 }, 1));
            Console.WriteLine(GroupSumClump(0, new int[] { 9 }, 1));

        }

        private static bool GroupSumClump(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            int i = start;
            int sum = nums[i];
            while (i < nums.Length - 1 && nums[i] == nums[i + 1])
            {
                sum += nums[i];
                i++;
            }
            if (GroupSumClump(i + 1, nums, target - sum)) return true;
            return GroupSumClump(i + 1, nums, target);
        }
    }
}

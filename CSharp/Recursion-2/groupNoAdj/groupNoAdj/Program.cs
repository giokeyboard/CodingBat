using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupNoAdj
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, is it possible to choose a group of some of the ints,
             * such that the group sums to the given target with this additional constraint:
             * If a value in the array is chosen to be in the group, the value immediately following it
             * in the array must not be chosen. (No loops needed.)
             *
             * groupNoAdj(0, [2, 5, 10, 4], 12) → true
             * groupNoAdj(0, [2, 5, 10, 4], 14) → false
             * groupNoAdj(0, [2, 5, 10, 4], 7) → false
             */
            Console.WriteLine(GroupNoAdj(0, new int[] { 2, 5, 10, 4 }, 12));
            Console.WriteLine(GroupNoAdj(0, new int[] { 2, 5, 10, 4 }, 14));
            Console.WriteLine(GroupNoAdj(0, new int[] { 2, 5, 10, 4 }, 7));
        }

        private static bool GroupNoAdj(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            if (GroupNoAdj(start + 2, nums, target - nums[start])) return true;
            return GroupNoAdj(start + 1, nums, target);
        }
    }
}

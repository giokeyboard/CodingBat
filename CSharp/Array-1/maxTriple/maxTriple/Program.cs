using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints of odd length,
             * look at the first, last, and middle values in the array and return the largest.
             * The array length will be a least 1.
             *
             * maxTriple([1, 2, 3]) → 3
             * maxTriple([1, 5, 3]) → 5
             * maxTriple([5, 2, 3]) → 5
             */
            Console.WriteLine(MaxTriple(new int[] { 1, 2, 3 }));
            Console.WriteLine(MaxTriple(new int[] { 1, 5, 3 }));
            Console.WriteLine(MaxTriple(new int[] { 5, 2, 3 }));
        }

        private static int MaxTriple(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2 || nums.Length % 2 == 0)
            {
                return Math.Max(nums[0], nums[1]);
            }
            int max = (nums[0] > nums[nums.Length / 2]) ? nums[0] : nums[nums.Length / 2];
            max = (max > nums[nums.Length - 1]) ? max : nums[nums.Length - 1];
            return max;
        }
    }
}

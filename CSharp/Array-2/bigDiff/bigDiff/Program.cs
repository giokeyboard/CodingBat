using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array length 1 or more of ints, return the difference between the largest and smallest values in the array.
             * Note: the built-in Math.min(v1, v2) and Math.max(v1, v2) methods return the smaller or larger of two values.
             *
             * bigDiff([10, 3, 5, 6]) → 7
             * bigDiff([7, 2, 10, 9]) → 8
             * bigDiff([2, 10, 7, 2]) → 8
             */
            Console.WriteLine(BigDiff(new int[] { 10, 3, 5, 6 }));
            Console.WriteLine(BigDiff(new int[] { 7, 2, 10, 9 }));
            Console.WriteLine(BigDiff(new int[] { 2, 10, 7, 2 }));
        }

        private static int BigDiff(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                min = Math.Min(nums[i], min);
                max = Math.Max(nums[i], max);
            }
            return max - min;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, swap the first and last elements in the array.
             * Return the modified array. The array length will be at least 1.
             *
             * swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
             * swapEnds([1, 2, 3]) → [3, 2, 1]
             * swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
             */
            Console.WriteLine($"[{String.Join(",", swapEnds(new int[] { 1, 2, 3, 4 }))}]");
            Console.WriteLine($"[{String.Join(",", swapEnds(new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", swapEnds(new int[] { 8, 6, 7, 9, 5 }))}]");
        }

        private static int[] swapEnds(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums;
            }
            int temp = nums[0];
            nums[0] = nums[nums.Length - 1];
            nums[nums.Length - 1] = temp;
            return nums;
        }
    }
}

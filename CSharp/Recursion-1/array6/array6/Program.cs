using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, compute recursively if the array contains a 6.
             * We'll use the convention of considering only the part of the array that begins at the given index.
             * In this way, a recursive call can pass index+1 to move down the array.
             * The initial call will pass in index as 0.
             *
             * array6([1, 6, 4], 0) → true
             * array6([1, 4], 0) → false
             * array6([6], 0) → true
             */
            Console.WriteLine(array6(new int[] { 1, 6, 4 }, 0));
            Console.WriteLine(array6(new int[] { 1, 4 }, 0));
            Console.WriteLine(array6(new int[] { 6 }, 0));
        }

        private static bool array6(int[] nums, int index)
        {
            if (index >= nums.Length) return false;
            return nums[index] == 6 || array6(nums, index + 1);
        }
    }
}

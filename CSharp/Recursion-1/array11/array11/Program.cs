using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, compute recursively the number of times that the value 11 appears in the array.
             * We'll use the convention of considering only the part of the array that begins at the given index.
             * In this way, a recursive call can pass index+1 to move down the array.
             * The initial call will pass in index as 0.
             *
             * array11([1, 2, 11], 0) → 1
             * array11([11, 11], 0) → 2
             * array11([1, 2, 3, 4], 0) → 0
             */
            Console.WriteLine(Array11(new int[] { 1, 2, 11 }, 0));
            Console.WriteLine(Array11(new int[] { 11, 11 }, 0));
            Console.WriteLine(Array11(new int[] { 1, 2, 3, 4 }, 0));
        }

        private static int Array11(int[] nums, int index)
        {
            if (index >= nums.Length) return 0;
            if (nums[index] == 11) return 1 + Array11(nums, index + 1);
            return Array11(nums, index + 1);
        }
    }
}

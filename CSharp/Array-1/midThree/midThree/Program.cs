using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints of odd length,
             * return a new array length 3 containing the elements from the middle of the array.
             * The array length will be at least 3.
             *
             * midThree([1, 2, 3, 4, 5]) → [2, 3, 4]
             * midThree([8, 6, 7, 5, 3, 0, 9]) → [7, 5, 3]
             * midThree([1, 2, 3]) → [1, 2, 3]
             */
            Console.WriteLine($"[{String.Join(",", MidThree(new int[] { 1, 2, 3, 4, 5 }))}]");
            Console.WriteLine($"[{String.Join(",", MidThree(new int[] { 8, 6, 7, 5, 3, 0, 9 }))}]");
            Console.WriteLine($"[{String.Join(",", MidThree(new int[] { 1, 2, 3 }))}]");
        }

        private static int[] MidThree(int[] nums)
        {
            return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1] };
        }
    }
}

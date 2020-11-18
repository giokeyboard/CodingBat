using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given an int array, return a new array with double the length where
            * its last element is the same as the original array, and all the other elements are 0.
            * The original array will be length 1 or more. Note: by default, a new int array contains all 0's.
            *
            * makeLast([4, 5, 6]) → [0, 0, 0, 0, 0, 6]
            * makeLast([1, 2]) → [0, 0, 0, 2]
            * makeLast([3]) → [0, 3]
            */
            Console.WriteLine($"[{String.Join(",", makeLast(new int[] { 4, 5, 6 }))}]");
            Console.WriteLine($"[{String.Join(",", makeLast(new int[] { 1, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", makeLast(new int[] { 3 }))}]");
        }

        private static int[] makeLast(int[] nums)
        {
            int[] output = new int[nums.Length * 2];
            output[output.Length - 1] = nums[nums.Length - 1];
            return output;
        }
    }
}

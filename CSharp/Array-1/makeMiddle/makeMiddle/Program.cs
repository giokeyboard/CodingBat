using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints of even length,
             * return a new array length 2 containing the middle two elements from the original array.
             * The original array will be length 2 or more.
             *
             * makeMiddle([1, 2, 3, 4]) → [2, 3]
             * makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
             * makeMiddle([1, 2]) → [1, 2]
             */
            Console.WriteLine($"[{String.Join(",", MakeMiddle(new int[] { 1, 2, 3, 4 }))}]");
            Console.WriteLine($"[{String.Join(",", MakeMiddle(new int[] { 7, 1, 2, 3, 4, 9 }))}]");
            Console.WriteLine($"[{String.Join(",", MakeMiddle(new int[] { 1, 2 }))}]");
        }

        private static int[] MakeMiddle(int[] nums)
        {
            return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
        }
    }
}

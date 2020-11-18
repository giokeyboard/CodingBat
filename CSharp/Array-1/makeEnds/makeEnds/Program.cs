using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given an array of ints, return a new array length 2 containing
            * the first and last elements from the original array.
            * The original array will be length 1 or more.
            *
            * makeEnds([1, 2, 3]) → [1, 3]
            * makeEnds([1, 2, 3, 4]) → [1, 4]
            * makeEnds([7, 4, 6, 2]) → [7, 2]
            */
            Console.WriteLine($"[{String.Join(",", MakeEnds(new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", MakeEnds(new int[] { 1, 2, 3, 4 }))}]");
            Console.WriteLine($"[{String.Join(",", MakeEnds(new int[] { 7, 4, 6, 2 }))}]");
        }

        private static int[] MakeEnds(int[] nums)
        {
            return new int[] { (nums.Length < 2) ? nums[0] : nums[0], nums[nums.Length - 1] };
        }
    }
}

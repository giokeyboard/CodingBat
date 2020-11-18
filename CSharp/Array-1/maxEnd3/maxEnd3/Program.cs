using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxEnd3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints length 3, figure out which is larger, the first or last element in the array,
             * and set all the other elements to be that value. Return the changed array.
             *
             * maxEnd3([1, 2, 3]) → [3, 3, 3]
             * maxEnd3([11, 5, 9]) → [11, 11, 11]
             * maxEnd3([2, 11, 3]) → [3, 3, 3]
             */
            Console.WriteLine($"[{String.Join(",", maxEnd3(new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", maxEnd3(new int[] { 11, 5, 9 }))}]");
            Console.WriteLine($"[{String.Join(",", maxEnd3(new int[] { 2, 11, 3 }))}]");
        }

        private static int[] maxEnd3(int[] nums)
        {
            int max = (nums[0] > nums[2]) ? nums[0] : nums[2];
            return new int[] { max, max, max };
        }
    }
}

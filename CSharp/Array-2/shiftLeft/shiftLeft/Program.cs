using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shiftLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return an array that is "left shifted" by one -- so {6, 2, 5, 3} returns {2, 5, 3, 6}.
             * You may modify and return the given array, or return a new array.
             *
             * shiftLeft([6, 2, 5, 3]) → [2, 5, 3, 6]
             * shiftLeft([1, 2]) → [2, 1]
             * shiftLeft([1]) → [1]
             */
            Console.WriteLine($"[{String.Join(",", shiftLeft(new int[] { 6, 2, 5, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", shiftLeft(new int[] { 1, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", shiftLeft(new int[] { 1 }))}]");
        }

        private static int[] shiftLeft(int[] nums)
        {
            if (nums.Length < 2) return nums;
            int temp = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            return nums;
        }
    }
}

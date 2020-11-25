using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeroMax
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return a version of the given array where each zero value in the array is replaced by the largest odd value
             * to the right of the zero in the array. If there is no odd value to the right of the zero, leave the zero as a zero.
             *
             * zeroMax([0, 5, 0, 3]) → [5, 5, 3, 3]
             * zeroMax([0, 4, 0, 3]) → [3, 4, 3, 3]
             * zeroMax([0, 1, 0]) → [1, 1, 0]
             */
            Console.WriteLine($"[{String.Join(",", ZeroMax(new int[] { 0, 5, 0, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", ZeroMax(new int[] { 0, 4, 0, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", ZeroMax(new int[] { 0, 1, 0 }))}]");
        }

        private static int[] ZeroMax(int[] nums)
        {
            int max = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] % 2 != 0 && nums[i] > max) max = nums[i];
                else if (nums[i] == 0) nums[i] = max;
            }
            return nums;
        }
    }
}

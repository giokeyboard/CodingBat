using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return the sum of the first 2 elements in the array.
             * If the array length is less than 2, just sum up the elements that exist, returning 0 if the array is length 0.
             *
             * sum2([1, 2, 3]) → 3
             * sum2([1, 1]) → 2
             * sum2([1, 1, 1, 1]) → 2
             */
            Console.WriteLine(sum2(new int[] { 1, 2, 3 }));
            Console.WriteLine(sum2(new int[] { 1, 1 }));
            Console.WriteLine(sum2(new int[] { 1, 1, 1, 1 }));
        }

        private static int sum2(int[] nums)
        {
            if (nums.Length == 0) { return 0; }
            if (nums.Length == 1) { return 1; }
            return nums[0] + nums[1];
        }
    }
}

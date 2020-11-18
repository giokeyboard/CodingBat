using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sameFirstLast
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the array is length 1 or more,
             * and the first element and the last element are equal.
             *
             * sameFirstLast([1, 2, 3]) → false
             * sameFirstLast([1, 2, 3, 1]) → true
             * sameFirstLast([1, 2, 1]) → true
             */
            Console.WriteLine(SameFirstLast(new int[] { 1, 2, 3 }));
            Console.WriteLine(SameFirstLast(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(SameFirstLast(new int[] { 1, 2, 1 }));
        }

        private static bool SameFirstLast(int[] nums)
        {
            return nums.Length >= 1 && nums[0] == nums[nums.Length - 1];
        }
    }
}

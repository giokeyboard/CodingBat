using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayFront9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4.
             *
             * arrayFront9([1, 2, 9, 3, 4]) → true
             * arrayFront9([1, 2, 3, 4, 9]) → false
             * arrayFront9([1, 2, 3, 4, 5]) → false
             */
            Console.WriteLine(ArrayFront9(new int[] { 1, 2, 9, 3, 4 }));
            Console.WriteLine(ArrayFront9(new int[] { 1, 2, 3, 4, 9 }));
            Console.WriteLine(ArrayFront9(new int[] { 1, 2, 3, 4, 5 }));
        }

        private static bool ArrayFront9(int[] nums)
        {
            int len = (nums.Length > 4) ? 4 : nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == 9) { return true; }
            }
            return false;
        }
    }
}

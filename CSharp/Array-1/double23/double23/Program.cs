using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given an int array, return true if the array contains 2 twice, or 3 twice. The array will be length 0, 1, or 2.
            *
            * double23([2, 2]) → true
            * double23([3, 3]) → true
            * double23([2, 3]) → false
            */
            Console.WriteLine(Double23(new int[] { 2, 2 }));
            Console.WriteLine(Double23(new int[] { 3, 3 }));
            Console.WriteLine(Double23(new int[] { 2, 3 }));
        }

        private static bool Double23(int[] nums)
        {
            return nums.Length > 1 && nums[0] == nums[1] && (nums[0] == 2 || nums[0] == 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace has271
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if it contains a 2, 7, 1 pattern:
             * a value, followed by the value plus 5, followed by the value minus 1.
             * Additionally the 271 counts even if the "1" differs by 2 or less from the correct value.
             *
             * has271([1, 2, 7, 1]) → true
             * has271([1, 2, 8, 1]) → false
             * has271([2, 7, 1]) → true
             */
            Console.WriteLine(Has271(new int[] { 1, 2, 7, 1 }));
            Console.WriteLine(Has271(new int[] { 1, 2, 8, 1 }));
            Console.WriteLine(Has271(new int[] { 2, 7, 1 }));
        }

        private static bool Has271(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if ((nums[i + 1] == nums[i] + 5) && (Math.Abs(nums[i + 2] - (nums[i] - 1)) <= 2)) { return true; }
            }
            return false;
        }
    }
}

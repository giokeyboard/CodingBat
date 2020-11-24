using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if it contains no 1's or it contains no 4's.
             *
             * no14([1, 2, 3]) → true
             * no14([1, 2, 3, 4]) → false
             * no14([2, 3, 4]) → true
             */
            Console.WriteLine(No14(new int[] { 1, 2, 3 }));
            Console.WriteLine(No14(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(No14(new int[] { 2, 3, 4 }));
        }

        private static bool No14(int[] nums)
        {
            bool containsOne = false;
            bool containsFour = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) containsOne = true;
                if (nums[i] == 4) containsFour = true;
            }
            return !(containsOne && containsFour);
        }
    }
}

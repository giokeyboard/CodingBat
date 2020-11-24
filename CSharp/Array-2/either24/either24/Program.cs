using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace either24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the array contains a 2 next to a 2 or a 4 next to a 4, but not both.
             *
             * either24([1, 2, 2]) → true
             * either24([4, 4, 1]) → true
             * either24([4, 4, 1, 2, 2]) → false
             */
            Console.WriteLine(Either24(new int[] { 1, 2, 2 }));
            Console.WriteLine(Either24(new int[] { 4, 4, 1 }));
            Console.WriteLine(Either24(new int[] { 4, 4, 1, 2, 2 }));
        }

        private static bool Either24(int[] nums)
        {
            bool flag2 = false;
            bool flag4 = false;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1] && nums[i] == 2) flag2 = true;
                if (nums[i] == nums[i + 1] && nums[i] == 4) flag4 = true;
                if (flag2 && flag4) return false;
            }
            return flag2 != flag4;
        }
    }
}

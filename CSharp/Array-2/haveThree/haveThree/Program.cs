using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haveThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the value 3 appears in the array exactly 3 times,
             * and no 3's are next to each other.
             *
             * haveThree([3, 1, 3, 1, 3]) → true
             * haveThree([3, 1, 3, 3]) → false
             * haveThree([3, 4, 3, 3, 4]) → false
             */
            Console.WriteLine(HaveThree(new int[] { 3, 1, 3, 1, 3 }));
            Console.WriteLine(HaveThree(new int[] { 3, 1, 3, 3 }));
            Console.WriteLine(HaveThree(new int[] { 3, 4, 3, 3, 4 }));
        }

        private static bool HaveThree(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    if (i > 0 && nums[i - 1] == nums[i]) return false;
                    else count++;
                }
            }
            return count == 3;
        }
    }
}

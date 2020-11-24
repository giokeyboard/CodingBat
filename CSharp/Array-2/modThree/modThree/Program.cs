using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the array contains either 3 even or 3 odd values all next to each other.
             *
             * modThree([2, 1, 3, 5]) → true
             * modThree([2, 1, 2, 5]) → false
             * modThree([2, 4, 2, 5]) → true
             */
            Console.WriteLine(ModThree(new int[] { 2, 1, 3, 5 }));
            Console.WriteLine(ModThree(new int[] { 2, 1, 2, 5 }));
            Console.WriteLine(ModThree(new int[] { 2, 4, 2, 5 }));
        }

        private static bool ModThree(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if ((nums[i] % 2 == 0 && nums[i + 1] % 2 == 0 && nums[i + 2] % 2 == 0) ||
                        (nums[i] % 2 != 0 && nums[i + 1] % 2 != 0 && nums[i + 2] % 2 != 0)) return true;
            }
            return false;
        }
    }
}

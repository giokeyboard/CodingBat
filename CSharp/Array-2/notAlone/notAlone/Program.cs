using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notAlone
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that an element in an array is "alone" if there are values before and after it,
             * and those values are different from it. Return a version of the given array where every instance of
             * the given value which is alone is replaced by whichever value to its left or right is larger.
             *
             * notAlone([1, 2, 3], 2) → [1, 3, 3]
             * notAlone([1, 2, 3, 2, 5, 2], 2) → [1, 3, 3, 5, 5, 2]
             * notAlone([3, 4], 3) → [3, 4]
             */
            Console.WriteLine($"[{String.Join(",", NotAlone(new int[] { 1, 2, 3 }, 2))}]");
            Console.WriteLine($"[{String.Join(",", NotAlone(new int[] { 1, 2, 3, 2, 5, 2 }, 2))}]");
            Console.WriteLine($"[{String.Join(",", NotAlone(new int[] { 3, 4 }, 3))}]");
        }

        private static int[] NotAlone(int[] nums, int val)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val && i > 0 && i < nums.Length - 1 && nums[i - 1] != nums[i] && nums[i + 1] != nums[i])
                {
                    nums[i] = (nums[i + 1] > nums[i - 1]) ? nums[i + 1] : nums[i - 1];
                }
            }
            return nums;
        }
    }
}

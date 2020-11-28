using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix34
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return an array that contains exactly the same numbers as the given array, but rearranged so that
             * every 3 is immediately followed by a 4. Do not move the 3's, but every other number may move.
             * The array contains the same number of 3's and 4's, every 3 has a number after it that is not a 3,
             * and a 3 appears in the array before any 4.
             *
             * fix34([1, 3, 1, 4]) → [1, 3, 4, 1]
             * fix34([1, 3, 1, 4, 4, 3, 1]) → [1, 3, 4, 1, 1, 3, 4]
             * fix34([3, 2, 2, 4]) → [3, 4, 2, 2]
             */
            Console.WriteLine($"[{String.Join(",", Fix34(new int[] { 1, 3, 1, 4 }))}]");
            Console.WriteLine($"[{String.Join(",", Fix34(new int[] { 1, 3, 1, 4, 4, 3, 1 }))}]");
            Console.WriteLine($"[{String.Join(",", Fix34(new int[] { 3, 2, 2, 4 }))}]");
        }

        private static int[] Fix34(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == 4 && nums[j - 1] != 3)
                        {
                            int temp = nums[i + 1];
                            nums[i + 1] = nums[j];
                            nums[j] = temp;
                            i++;
                            break;
                        }
                    }
                }
            }

            return nums;
        }
    }
}

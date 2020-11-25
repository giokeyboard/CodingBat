using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return an array that contains the exact same numbers as the given array, but rearranged so that
             * all the even numbers come before all the odd numbers. Other than that, the numbers can be in any order.
             * You may modify and return the given array, or make a new array.
             *
             * evenOdd([1, 0, 1, 0, 0, 1, 1]) → [0, 0, 0, 1, 1, 1, 1]
             * evenOdd([3, 3, 2]) → [2, 3, 3]
             * evenOdd([2, 2, 2]) → [2, 2, 2]
             */
            Console.WriteLine($"[{String.Join(",", evenOdd(new int[] { 1, 0, 1, 0, 0, 1, 1 }))}]");
            Console.WriteLine($"[{String.Join(",", evenOdd(new int[] { 3, 3, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", evenOdd(new int[] { 2, 2, 2 }))}]");
        }

        private static int[] evenOdd(int[] nums)
        {
            int index = 0;
            while (index < nums.Length && nums[index] % 2 == 0) index++;

            for (int i = index + 1; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int temp = nums[index];
                    nums[index++] = nums[i];
                    nums[i] = temp;
                }
            }

            return nums;
        }
    }
}

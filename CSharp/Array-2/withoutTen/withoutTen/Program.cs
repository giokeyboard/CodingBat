using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutTen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return a version of the given array where all the 10's have been removed.
             * The remaining elements should shift left towards the start of the array as needed,
             * and the empty spaces a the end of the array should be 0. So {1, 10, 10, 2} yields {1, 2, 0, 0}.
             * You may modify and return the given array or make a new array.
             *
             * withoutTen([1, 10, 10, 2]) → [1, 2, 0, 0]
             * withoutTen([10, 2, 10]) → [2, 0, 0]
             * withoutTen([1, 99, 10]) → [1, 99, 0]
             */
            Console.WriteLine($"[{String.Join(",", WithoutTen(new int[] { 1, 10, 10, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", WithoutTen(new int[] { 10, 2, 10 }))}]");
            Console.WriteLine($"[{String.Join(",", WithoutTen(new int[] { 1, 99, 10 }))}]");
            Console.WriteLine($"[{String.Join(",", WithoutTen(new int[] { 1 }))}]");
            Console.WriteLine($"[{String.Join(",", WithoutTen(new int[] { 1, 13, 13, 1 }))}]");
            Console.WriteLine($"[{String.Join(",", WithoutTen(new int[] { }))}]");
        }

        private static int[] WithoutTen(int[] nums)
        {
            int index = 0;
            while (index < nums.Length && nums[index] != 10) index++;

            for (int i = index + 1; i < nums.Length; i++)
            {
                if (nums[i] != 10)
                {
                    int temp = nums[index];
                    nums[index++] = nums[i];
                    nums[i] = temp;
                }
            }

            for (; index < nums.Length; index++)
            {
                nums[index] = 0;
            }

            return nums;
        }
    }
}

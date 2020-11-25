using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-empty array of ints, return a new array containing the elements from the original array
             * that come after the last 4 in the original array. The original array will contain at least one 4.
             * Note that it is valid in java to create an array of length 0.
             *
             * post4([2, 4, 1, 2]) → [1, 2]
             * post4([4, 1, 4, 2]) → [2]
             * post4([4, 4, 1, 2, 3]) → [1, 2, 3]
             */
            Console.WriteLine($"[{String.Join(",", Post4(new int[] { 2, 4, 1, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", Post4(new int[] { 4, 1, 4, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", Post4(new int[] { 4, 4, 1, 2, 3 }))}]");
        }

        private static int[] Post4(int[] nums)
        {
            int index = nums.Length - 1;
            while (nums[index] != 4) index--;
            index++;

            int[] result = new int[nums.Length - index];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums[index++];
            }

            return result;
        }
    }
}

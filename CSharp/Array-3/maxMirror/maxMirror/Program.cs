using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxMirror
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a "mirror" section in an array is a group of contiguous elements such that
             * somewhere in the array, the same group appears in reverse order.
             * For example, the largest mirror section in {1, 2, 3, 8, 9, 3, 2, 1} is length 3 (the {1, 2, 3} part).
             * Return the size of the largest mirror section found in the given array.
             *
             * maxMirror([1, 2, 3, 8, 9, 3, 2, 1]) → 3
             * maxMirror([1, 2, 1, 4]) → 3
             * maxMirror([7, 1, 2, 9, 7, 2, 1]) → 2
             */
            Console.WriteLine(MaxMirror(new int[] { 1, 2, 3, 8, 9, 3, 2, 1 }));
            Console.WriteLine(MaxMirror(new int[] { 1, 2, 1, 4 }));
            Console.WriteLine(MaxMirror(new int[] { 7, 1, 2, 9, 7, 2, 1 }));
        }

        private static int MaxMirror(int[] nums)
        {
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = nums.Length - 1; j >= 0 && i + count < nums.Length; j--)
                {
                    if (nums[i + count] == nums[j])
                    {
                        count++;
                    }
                    else
                    {
                        max = Math.Max(max, count);
                        count = 0;
                    }
                }
                max = Math.Max(max, count);
            }

            return max;
        }
    }
}

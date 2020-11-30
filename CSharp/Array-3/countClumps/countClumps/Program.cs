using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countClumps
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value.
             * Return the number of clumps in the given array.
             *
             * countClumps([1, 2, 2, 3, 4, 4]) → 2
             * countClumps([1, 1, 2, 1, 1]) → 2
             * countClumps([1, 1, 1, 1, 1]) → 1
             */
            Console.WriteLine(CountClumps(new int[] { 1, 2, 2, 3, 4, 4 }));
            Console.WriteLine(CountClumps(new int[] { 1, 1, 2, 1, 1 }));
            Console.WriteLine(CountClumps(new int[] { 1, 1, 1, 1, 1 }));
        }

        private static int CountClumps(int[] nums)
        {
            int i = 0;
            int j = i + 1;
            int clumps = 0;

            while (i < nums.Length)
            {
                while (j < nums.Length && nums[i] == nums[j])
                {
                    j++;
                }

                if (j > i + 1)
                {
                    if (i == 0) clumps++;
                    else if (i > 0 && nums[i - 1] != nums[i]) clumps++;
                }
                i++;
            }

            return clumps;
        }
    }
}

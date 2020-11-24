using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchUp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given arrays nums1 and nums2 of the same length, for every element in nums1,
             * consider the corresponding element in nums2 (at the same index).
             * Return the count of the number of times that the two elements differ by 2 or less, but are not equal.
             *
             * matchUp([1, 2, 3], [2, 3, 10]) → 2
             * matchUp([1, 2, 3], [2, 3, 5]) → 3
             * matchUp([1, 2, 3], [2, 3, 3]) → 2
             */
            Console.WriteLine(MatchUp(new int[] { 1, 2, 3 }, new int[] { 2, 3, 10 }));
            Console.WriteLine(MatchUp(new int[] { 1, 2, 3 }, new int[] { 2, 3, 5 }));
            Console.WriteLine(MatchUp(new int[] { 1, 2, 3 }, new int[] { 2, 3, 3 }));
        }

        private static int MatchUp(int[] nums1, int[] nums2)
        {
            int count = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                if (Math.Abs(nums1[i] - nums2[i]) <= 2 && nums1[i] != nums2[i]) count++;
            }
            return count;
        }
    }
}

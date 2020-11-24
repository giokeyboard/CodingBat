using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sameEnds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the group of N numbers at the start and end of the array are the same.
             * For example, with {5, 6, 45, 99, 13, 5, 6}, the ends are the same for n=0 and n=2, and false for n=1 and n=3.
             * You may assume that n is in the range 0..nums.length inclusive.
             *
             * sameEnds([5, 6, 45, 99, 13, 5, 6], 1) → false
             * sameEnds([5, 6, 45, 99, 13, 5, 6], 2) → true
             * sameEnds([5, 6, 45, 99, 13, 5, 6], 3) → false
             */
            Console.WriteLine(SameEnds(new int[] { 5, 6, 45, 99, 13, 5, 6 }, 1));
            Console.WriteLine(SameEnds(new int[] { 5, 6, 45, 99, 13, 5, 6 }, 2));
            Console.WriteLine(SameEnds(new int[] { 5, 6, 45, 99, 13, 5, 6 }, 3));
        }

        private static bool SameEnds(int[] nums, int len)
        {
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != nums[nums.Length - len + i]) return false;
            }
            return true;
        }
    }
}

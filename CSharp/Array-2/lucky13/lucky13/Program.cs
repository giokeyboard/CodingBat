using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucky13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the array contains no 1's and no 3's.
             *
             * lucky13([0, 2, 4]) → true
             * lucky13([1, 2, 3]) → false
             * lucky13([1, 2, 4]) → false
             */
            Console.WriteLine(Lucky13(new int[] { 0, 2, 4 }));
            Console.WriteLine(Lucky13(new int[] { 1, 2, 3 }));
            Console.WriteLine(Lucky13(new int[] { 1, 2, 4 }));
        }

        private static bool Lucky13(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1 || nums[i] == 3) return false;
            }
            return true;
        }
    }
}

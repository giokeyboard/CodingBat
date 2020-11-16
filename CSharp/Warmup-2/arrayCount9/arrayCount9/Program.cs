using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayCount9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return the number of 9's in the array.
             *
             * arrayCount9([1, 2, 9]) → 1
             * arrayCount9([1, 9, 9]) → 2
             * arrayCount9([1, 9, 9, 3, 9]) → 3
             */
            Console.WriteLine(ArrayCount9(new int[] { 1, 2, 9 }));
            Console.WriteLine(ArrayCount9(new int[] { 1, 9, 9 }));
            Console.WriteLine(ArrayCount9(new int[] { 1, 9, 9, 3, 9 }));
        }

        private static int ArrayCount9(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 9) { count++; }
            }
            return count;
        }
    }
}

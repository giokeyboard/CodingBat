using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array123
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the sequence of numbers 1, 2, 3 appears in the array somewhere.
             *
             * array123([1, 1, 2, 3, 1]) → true
             * array123([1, 1, 2, 4, 1]) → false
             * array123([1, 1, 2, 1, 2, 3]) → true
             */
            Console.WriteLine(Array123(new int[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(Array123(new int[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(Array123(new int[] { 1, 1, 2, 1, 2, 3 }));
        }

        private static bool Array123(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 1 && nums[i + 1] == 2 && nums[i + 2] == 3) { return true; }
            }
            return false;
        }
    }
}

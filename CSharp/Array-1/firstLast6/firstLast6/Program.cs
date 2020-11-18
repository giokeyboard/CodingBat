using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLast6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if 6 appears as either the first or last element in the array.
             * The array will be length 1 or more.
             *
             * firstLast6([1, 2, 6]) → true
             * firstLast6([6, 1, 2, 3]) → true
             * firstLast6([13, 6, 1, 2, 3]) → false
             */
            Console.WriteLine(firstLast6(new int[] { 1, 2, 6 }));
            Console.WriteLine(firstLast6(new int[] { 6, 1, 2, 3 }));
            Console.WriteLine(firstLast6(new int[] { 13, 6, 1, 2, 3 }));
        }

        private static bool firstLast6(int[] nums)
        {
            return nums[0] == 6 || nums[nums.Length - 1] == 6;
        }
    }
}

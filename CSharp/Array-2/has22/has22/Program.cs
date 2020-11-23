using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace has22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
             *
             * has22([1, 2, 2]) → true
             * has22([1, 2, 1, 2]) → false
             * has22([2, 1, 2]) → false
             */
            Console.WriteLine(Has22(new int[] { 1, 2, 2 }));
            Console.WriteLine(Has22(new int[] { 1, 2, 1, 2 }));
            Console.WriteLine(Has22(new int[] { 2, 1, 2 }));
        }

        private static bool Has22(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 2 && nums[i] == nums[i + 1]) return true;
            }
            return false;
        }
    }
}

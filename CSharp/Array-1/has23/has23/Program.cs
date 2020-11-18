using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace has23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an int array length 2, return true if it contains a 2 or a 3.
             *
             * has23([2, 5]) → true
             * has23([4, 3]) → true
             * has23([4, 5]) → false
             */
            Console.WriteLine(has23(new int[] { 2, 5 }));
            Console.WriteLine(has23(new int[] { 4, 3 }));
            Console.WriteLine(has23(new int[] { 4, 5 }));
        }

        private static bool has23(int[] nums)
        {
            return nums[0] == 2 || nums[0] == 3 || nums[1] == 2 || nums[1] == 3;
        }
    }
}

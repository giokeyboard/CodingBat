using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace has12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in the array.
             *
             * has12([1, 3, 2]) → true
             * has12([3, 1, 2]) → true
             * has12([3, 1, 4, 5, 2]) → true
             */
            Console.WriteLine(Has12(new int[] { 1, 3, 2 }));
            Console.WriteLine(Has12(new int[] { 3, 1, 2 }));
            Console.WriteLine(Has12(new int[] { 3, 1, 4, 5, 2 }));
        }

        private static bool Has12(int[] nums)
        {
            bool flag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) flag = true;
                if (flag && nums[i] == 2) return true;
            }
            return false;
        }
    }
}

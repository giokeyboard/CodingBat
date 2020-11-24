using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if every 2 that appears in the array is next to another 2.
             *
             * twoTwo([4, 2, 2, 3]) → true
             * twoTwo([2, 2, 4]) → true
             * twoTwo([2, 2, 4, 2]) → false
             */
            Console.WriteLine(TwoTwo(new int[] { 4, 2, 2, 3 }));
            Console.WriteLine(TwoTwo(new int[] { 2, 2, 4 }));
            Console.WriteLine(TwoTwo(new int[] { 2, 2, 4, 2 }));
        }

        private static bool TwoTwo(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    if ((i > 0 && nums[i - 1] == 2) || (i < nums.Length - 1 && nums[i + 1] == 2)) continue;
                    else return false;
                }
            }
            return true;
        }
    }
}

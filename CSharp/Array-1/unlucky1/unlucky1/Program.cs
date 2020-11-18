using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unlucky1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1.
             * Return true if the given array contains an unlucky 1 in the first 2 or last 2 positions in the array.
             *
             * unlucky1([1, 3, 4, 5]) → true
             * unlucky1([2, 1, 3, 4, 5]) → true
             * unlucky1([1, 1, 1]) → false
             */
            Console.WriteLine(Unlucky1(new int[] { 1, 3, 4, 5 }));
            Console.WriteLine(Unlucky1(new int[] { 2, 1, 3, 4, 5 }));
            Console.WriteLine(Unlucky1(new int[] { 1, 1, 1 }));
        }

        private static bool Unlucky1(int[] nums)
        {
            return nums.Length > 1 &&
                ((nums[0] == 1 && nums[1] == 3) ||
                        (nums[nums.Length - 2] == 1 && nums[nums.Length - 1] == 3) ||
                        (nums.Length > 2 && (nums[1] == 1 && nums[2] == 3)));
        }
    }
}

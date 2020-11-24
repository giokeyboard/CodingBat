using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace has77
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if the array contains two 7's next to each other,
             * or there are two 7's separated by one element, such as with {7, 1, 7}.
             *
             * has77([1, 7, 7]) → true
             * has77([1, 7, 1, 7]) → true
             * has77([1, 7, 1, 1, 7]) → false
             */
            Console.WriteLine(Has77(new int[] { 1, 7, 7 }));
            Console.WriteLine(Has77(new int[] { 1, 7, 1, 7 }));
            Console.WriteLine(Has77(new int[] { 1, 7, 1, 1, 7 }));
        }

        private static bool Has77(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 7)
                {
                    if (nums[i] == nums[i + 1]) return true;
                    if (i < nums.Length - 2 && nums[i] == nums[i + 2]) return true;
                }
            }
            return false;
        }
    }
}

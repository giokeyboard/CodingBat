using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum67
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the sum of the numbers in the array, except ignore sections of numbers starting with a 6 and
             * extending to the next 7 (every 6 will be followed by at least one 7). Return 0 for no numbers.
             *
             * sum67([1, 2, 2]) → 5
             * sum67([1, 2, 2, 6, 99, 99, 7]) → 5
             * sum67([1, 1, 6, 7, 2]) → 4
             */
            Console.WriteLine(Sum67(new int[] { 1, 2, 2 }));
            Console.WriteLine(Sum67(new int[] { 1, 2, 2, 6, 99, 99, 7 }));
            Console.WriteLine(Sum67(new int[] { 1, 1, 6, 7, 2 }));
        }

        private static int Sum67(int[] nums)
        {
            int sum = 0;
            bool skip = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 6) skip = true;
                if (skip && nums[i] == 7)
                {
                    skip = false;
                    continue;
                }
                if (!skip) sum += nums[i];
            }

            return sum;
        }
    }
}

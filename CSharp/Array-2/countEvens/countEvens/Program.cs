using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the number of even ints in the given array.
             * Note: the % "mod" operator computes the remainder, e.g. 5 % 2 is 1.
             *
             * countEvens([2, 1, 2, 3, 4]) → 3
             * countEvens([2, 2, 0]) → 3
             * countEvens([1, 3, 5]) → 0
             */
            Console.WriteLine(CountEvens(new int[] { 2, 1, 2, 3, 4 }));
            Console.WriteLine(CountEvens(new int[] { 2, 2, 0 }));
            Console.WriteLine(CountEvens(new int[] { 1, 3, 5 }));
        }

        private static int CountEvens(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) count++;
            }
            return count;
        }
    }
}

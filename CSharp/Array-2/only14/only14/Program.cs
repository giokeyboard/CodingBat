using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace only14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, return true if every element is a 1 or a 4.
             *
             * only14([1, 4, 1, 4]) → true
             * only14([1, 4, 2, 4]) → false
             * only14([1, 1]) → true
             */
            Console.WriteLine(Only14(new int[] { 1, 4, 1, 4 }));
            Console.WriteLine(Only14(new int[] { 1, 4, 2, 4 }));
            Console.WriteLine(Only14(new int[] { 1, 1 }));
        }

        private static bool Only14(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (!(nums[i] == 1 || nums[i] == 4)) return false;
            }
            return true;
        }
    }
}

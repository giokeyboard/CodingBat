using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints length 3, return the sum of all the elements.
             *
             * sum3([1, 2, 3]) → 6
             * sum3([5, 11, 2]) → 18
             * sum3([7, 0, 0]) → 7
             */
            Console.WriteLine(Sum3(new int[] { 1, 2, 3 }));
            Console.WriteLine(Sum3(new int[] { 5, 11, 2 }));
            Console.WriteLine(Sum3(new int[] { 7, 0, 0 }));
        }

        private static int Sum3(int[] nums)
        {
            return nums[0] + nums[1] + nums[2];
        }
    }
}

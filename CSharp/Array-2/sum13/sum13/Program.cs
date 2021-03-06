﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the sum of the numbers in the array, returning 0 for an empty array.
             * Except the number 13 is very unlucky, so it does not count and numbers that come
             * immediately after a 13 also do not count.
             *
             * sum13([1, 2, 2, 1]) → 6
             * sum13([1, 1]) → 2
             * sum13([1, 2, 2, 1, 13]) → 6
             */
            Console.WriteLine(Sum13(new int[] { 1, 2, 2, 1 }));
            Console.WriteLine(Sum13(new int[] { 1, 1 }));
            Console.WriteLine(Sum13(new int[] { 1, 2, 2, 1, 13 }));
        }

        private static int Sum13(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 13)
                {
                    i++;
                    continue;
                }
                sum += nums[i];
            }
            return sum;
        }
    }
}

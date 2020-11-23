﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centeredAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the "centered" average of an array of ints, which we'll say is the mean average of the values,
             * except ignoring the largest and smallest values in the array.
             * If there are multiple copies of the smallest value, ignore just one copy, and likewise for the largest value.
             * Use int division to produce the final average. You may assume that the array is length 3 or more.
             *
             * centeredAverage([1, 2, 3, 4, 100]) → 3
             * centeredAverage([1, 1, 5, 5, 10, 8, 7]) → 5
             * centeredAverage([-10, -4, -2, -4, -2, 0]) → -3
             */
            Console.WriteLine(CenteredAverage(new int[] { 1, 2, 3, 4, 100 }));
            Console.WriteLine(CenteredAverage(new int[] { 1, 1, 5, 5, 10, 8, 7 }));
            Console.WriteLine(CenteredAverage(new int[] { -10, -4, -2, -4, -2, 0 }));
        }

        private static int CenteredAverage(int[] nums)
        {
            int sum = nums[0];
            int max = nums[0];
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                max = Math.Max(nums[i], max);
                min = Math.Min(nums[i], min);
            }
            return (sum - max - min) / (nums.Length - 2);
        }
    }
}

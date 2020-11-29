using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-empty array, return true if there is a place to split the array so that
             * the sum of the numbers on one side is equal to the sum of the numbers on the other side.
             *
             * canBalance([1, 1, 1, 2, 1]) → true
             * canBalance([2, 1, 1, 2, 1]) → false
             * canBalance([10, 10]) → true
             */
            Console.WriteLine(CanBalance(new int[] { 1, 1, 1, 2, 1 }));
            Console.WriteLine(CanBalance(new int[] { 2, 1, 1, 2, 1 }));
            Console.WriteLine(CanBalance(new int[] { 10, 10 }));
        }

        private static bool CanBalance(int[] nums)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                sum1 += nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum2 += nums[j];
                }
                if (sum1 == sum2) return true;
                sum2 = 0;
            }

            return false;
        }
    }
}

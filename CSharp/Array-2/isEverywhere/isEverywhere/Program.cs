using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a value is "everywhere" in an array if for every pair of adjacent elements in the array,
             * at least one of the pair is that value. Return true if the given value is everywhere in the array.
             *
             * isEverywhere([1, 2, 1, 3], 1) → true
             * isEverywhere([1, 2, 1, 3], 2) → false
             * isEverywhere([1, 2, 1, 3, 4], 1) → false
             */
            Console.WriteLine(IsEverywhere(new int[] { 1, 2, 1, 3 }, 1));
            Console.WriteLine(IsEverywhere(new int[] { 1, 2, 1, 3 }, 2));
            Console.WriteLine(IsEverywhere(new int[] { 1, 2, 1, 3, 4 }, 1));
        }

        private static bool IsEverywhere(int[] nums, int val)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (!(nums[i] == val || nums[i + 1] == val)) return false;
            }
            return true;
        }
    }
}

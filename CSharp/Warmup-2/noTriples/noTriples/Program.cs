using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noTriples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array.
             * Return true if the array does not contain any triples.
             *
             * noTriples([1, 1, 2, 2, 1]) → true
             * noTriples([1, 1, 2, 2, 2, 1]) → false
             * noTriples([1, 1, 1, 2, 2, 2, 1]) → false
             */
            Console.WriteLine(NoTriples(new int[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(NoTriples(new int[] { 1, 1, 2, 2, 2, 1 }));
            Console.WriteLine(NoTriples(new int[] { 1, 1, 1, 2, 2, 2, 1 }));
        }

        private static bool NoTriples(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == nums[i + 1] && nums[i + 1] == nums[i + 2]) { return false; }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripleUp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the array contains, somewhere, three increasing adjacent numbers like
             * .... 4, 5, 6, ... or 23, 24, 25.
             *
             * tripleUp([1, 4, 5, 6, 2]) → true
             * tripleUp([1, 2, 3]) → true
             * tripleUp([1, 2, 4]) → false
             */
            Console.WriteLine(TripleUp(new int[] { 1, 4, 5, 6, 2 }));
            Console.WriteLine(TripleUp(new int[] { 1, 2, 3 }));
            Console.WriteLine(TripleUp(new int[] { 1, 2, 4 }));
        }

        private static bool TripleUp(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i + 2] - nums[i] == 2 && nums[i + 2] - nums[i + 1] == 1) return true;
            }
            return false;
        }
    }
}

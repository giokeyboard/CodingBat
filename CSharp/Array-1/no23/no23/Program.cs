using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given an int array length 2, return true if it does not contain a 2 or 3.
            *
            * no23([4, 5]) → true
            * no23([4, 2]) → false
            * no23([3, 5]) → false
            */
            Console.WriteLine(No23(new int[] { 4, 5 }));
            Console.WriteLine(No23(new int[] { 4, 2 }));
            Console.WriteLine(No23(new int[] { 3, 5 }));
        }

        private static bool No23(int[] nums)
        {
            return !(nums[0] == 2 || nums[0] == 3 || nums[1] == 2 || nums[1] == 3);
        }
    }
}

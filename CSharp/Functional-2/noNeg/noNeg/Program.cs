using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of integers, return a list of the integers, omitting any that are less than 0.
             *
             * noNeg([1, -2]) → [1]
             * noNeg([-3, -3, 3, 3]) → [3, 3]
             * noNeg([-1, -1, -1]) → []
             */
            Console.WriteLine($"[{String.Join(",", NoNeg(new List<int>(new int[] { 1, -2 })))}]");
            Console.WriteLine($"[{String.Join(",", NoNeg(new List<int>(new int[] { -3, -3, 3, 3 })))}]");
            Console.WriteLine($"[{String.Join(",", NoNeg(new List<int>(new int[] { -1, -1, -1 })))}]");
        }

        private static List<int> NoNeg(List<int> nums)
        {
            return nums.Where(x => x >= 0).ToList();
        }
    }
}

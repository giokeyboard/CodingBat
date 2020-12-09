using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of non-negative integers, return a list of those numbers except omitting any that end with 9.
             * (Note: % by 10)
             *
             * no9([1, 2, 19]) → [1, 2]
             * no9([9, 19, 29, 3]) → [3]
             * no9([1, 2, 3]) → [1, 2, 3]
             */
            Console.WriteLine($"[{String.Join(",", No9(new List<int>(new int[] { 1, 2, 19 })))}]");
            Console.WriteLine($"[{String.Join(",", No9(new List<int>(new int[] { 9, 19, 29, 3 })))}]");
            Console.WriteLine($"[{String.Join(",", No9(new List<int>(new int[] { 1, 2, 3 })))}]");
        }

        private static List<int> No9(List<int> nums)
        {
            return nums.Where(x => x % 10 != 9).ToList();
        }
    }
}

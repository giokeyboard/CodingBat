using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of non-negative integers, return a list of those numbers multiplied by 2,
             * omitting any of the resulting numbers that end in 2.
             *
             * two2([1, 2, 3]) → [4, 6]
             * two2([2, 6, 11]) → [4]
             * two2([0]) → [0]
             */
            Console.WriteLine($"[{String.Join(",", two2(new List<int>(new int[] { 1, 2, 3 })))}]");
            Console.WriteLine($"[{String.Join(",", two2(new List<int>(new int[] { 2, 6, 11 })))}]");
            Console.WriteLine($"[{String.Join(",", two2(new List<int>(new int[] { 0 })))}]");
        }

        private static List<int> two2(List<int> nums)
        {
            return nums.Select(x => 2 * x).Where(x => x % 10 != 2).ToList();
        }
    }
}

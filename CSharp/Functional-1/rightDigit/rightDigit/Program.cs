using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of non-negative integers, return an integer list of the rightmost digits. (Note: use %)
             *
             * rightDigit([1, 22, 93]) → [1, 2, 3]
             * rightDigit([16, 8, 886, 8, 1]) → [6, 8, 6, 8, 1]
             * rightDigit([10, 0]) → [0, 0]
             */
            Console.WriteLine($"[{String.Join(",", RightDigit(new List<int>(new int[] { 1, 22, 93 })))}]");
            Console.WriteLine($"[{String.Join(",", RightDigit(new List<int>(new int[] { 16, 8, 886, 8, 1 })))}]");
            Console.WriteLine($"[{String.Join(",", RightDigit(new List<int>(new int[] { 10, 0 })))}]");
        }

        private static List<int> RightDigit(List<int> nums)
        {
            return nums.Select(n => n % 10).ToList();
        }
    }
}

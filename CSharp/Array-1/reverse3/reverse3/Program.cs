using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of ints length 3, return a new array with the elements in reverse order,
             * so {1, 2, 3} becomes {3, 2, 1}.
             *
             * reverse3([1, 2, 3]) → [3, 2, 1]
             * reverse3([5, 11, 9]) → [9, 11, 5]
             * reverse3([7, 0, 0]) → [0, 0, 7]
             */
            Console.WriteLine($"[{String.Join(",", Reverse3(new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", Reverse3(new int[] { 5, 11, 9 }))}]");
            Console.WriteLine($"[{String.Join(",", Reverse3(new int[] { 7, 0, 0 }))}]");
        }

        private static int[] Reverse3(int[] nums)
        {
            return new int[] { nums[2], nums[1], nums[0] };
        }
    }
}

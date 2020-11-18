using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontPiece
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an int array of any length, return a new array of its first 2 elements.
             * If the array is smaller than length 2, use whatever elements are present.
             *
             * frontPiece([1, 2, 3]) → [1, 2]
             * frontPiece([1, 2]) → [1, 2]
             * frontPiece([1]) → [1]
             */
            Console.WriteLine($"[{String.Join(",", FrontPiece(new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", FrontPiece(new int[] { 1, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", FrontPiece(new int[] { 1 }))}]");
        }

        private static int[] FrontPiece(int[] nums)
        {
            if (nums.Length == 0) { return new int[] { }; }
            if (nums.Length == 1) { return new int[] { nums[0] }; }
            return new int[] { nums[0], nums[1] };
        }
    }
}

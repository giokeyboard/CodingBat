using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plusTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int arrays, each length 2, return a new array length 4 containing all their elements.
             *
             * plusTwo([1, 2], [3, 4]) → [1, 2, 3, 4]
             * plusTwo([4, 4], [2, 2]) → [4, 4, 2, 2]
             * plusTwo([9, 2], [3, 4]) → [9, 2, 3, 4]
             */
            Console.WriteLine($"[{String.Join(",", plusTwo(new int[] { 1, 2 }, new int[] { 3, 4 }))}]");
            Console.WriteLine($"[{String.Join(",", plusTwo(new int[] { 4, 4 }, new int[] { 2, 2 }))}]");
            Console.WriteLine($"[{String.Join(",", plusTwo(new int[] { 9, 2 }, new int[] { 3, 4 }))}]");
        }

        private static int[] plusTwo(int[] a, int[] b)
        {
            return new int[] { a[0], a[1], b[0], b[1] };
        }
    }
}

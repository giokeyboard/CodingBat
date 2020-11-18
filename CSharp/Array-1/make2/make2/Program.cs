using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace make2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int arrays, a and b, return a new array length 2 containing,
             * as much as will fit, the elements from a followed by the elements from b.
             * The arrays may be any length, including 0, but there will be 2 or more elements available between the 2 arrays.
             *
             * make2([4, 5], [1, 2, 3]) → [4, 5]
             * make2([4], [1, 2, 3]) → [4, 1]
             * make2([], [1, 2]) → [1, 2]
             */
            Console.WriteLine($"[{String.Join(",", Make2(new int[] { 4, 5 }, new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", Make2(new int[] { 4 }, new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[{String.Join(",", Make2(new int[] { }, new int[] { 1, 2 }))}]");
        }

        private static int[] Make2(int[] a, int[] b)
        {
            if (a.Length == 0) { return new int[] { b[0], b[1] }; }
            else if (a.Length == 1) { return new int[] { a[0], b[0] }; }
            return new int[] { a[0], a[1] };
        }
    }
}

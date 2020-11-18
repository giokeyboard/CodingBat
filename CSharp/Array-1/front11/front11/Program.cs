using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int arrays, a and b, of any length, return a new array with the first element of each array.
             * If either array is length 0, ignore that array.
             *
             * front11([1, 2, 3], [7, 9, 8]) → [1, 7]
             * front11([1], [2]) → [1, 2]
             * front11([1, 7], []) → [1]
             */
            Console.WriteLine($"[{String.Join(",", Front11(new int[] { 1, 2, 3 }, new int[] { 7, 9, 8 }))}]");
            Console.WriteLine($"[{String.Join(",", Front11(new int[] { 1 }, new int[] { 2 }))}]");
            Console.WriteLine($"[{String.Join(",", Front11(new int[] { 1, 7 }, new int[] { }))}]");
        }

        private static int[] Front11(int[] a, int[] b)
        {
            if (a.Length == 0) { return (b.Length == 0) ? new int[] { } : new int[] { b[0] }; }
            if (b.Length == 0) { return new int[] { a[0] }; }
            return new int[] { a[0], b[0] };
        }
    }
}

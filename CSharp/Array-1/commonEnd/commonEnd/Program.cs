using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 arrays of ints, a and b, return true if they have the same first element or
             * they have the same last element. Both arrays will be length 1 or more.
             *
             * commonEnd([1, 2, 3], [7, 3]) → true
             * commonEnd([1, 2, 3], [7, 3, 2]) → false
             * commonEnd([1, 2, 3], [1, 3]) → true
             */
            Console.WriteLine(CommonEnd(new int[] { 1, 2, 3 }, new int[] { 7, 3 }));
            Console.WriteLine(CommonEnd(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }));
            Console.WriteLine(CommonEnd(new int[] { 1, 2, 3 }, new int[] { 1, 3 }));
        }

        private static bool CommonEnd(int[] a, int[] b)
        {
            return a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1];
        }
    }
}

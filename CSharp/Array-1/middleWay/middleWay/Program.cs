using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middleWay
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle elements.
             *
             * middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
             * middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
             * middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
             */
            Console.WriteLine($"[{String.Join(",", middleWay(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }))}]");
            Console.WriteLine($"[{String.Join(",", middleWay(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }))}]");
            Console.WriteLine($"[{String.Join(",", middleWay(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }))}]");
        }

        private static int[] middleWay(int[] a, int[] b)
        {
            return new int[] { a[1], b[1] };
        }
    }
}

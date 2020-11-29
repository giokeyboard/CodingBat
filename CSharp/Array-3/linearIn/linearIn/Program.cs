using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearIn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two arrays of ints sorted in increasing order, outer and inner, return true if
             * all of the numbers in inner appear in outer. The best solution makes only a single
             * "linear" pass of both arrays, taking advantage of the fact that both arrays are already in sorted order.
             *
             * linearIn([1, 2, 4, 6], [2, 4]) → true
             * linearIn([1, 2, 4, 6], [2, 3, 4]) → false
             * linearIn([1, 2, 4, 4, 6], [2, 4]) → true
             */
            Console.WriteLine(LinearIn(new int[] { 1, 2, 4, 6 }, new int[] { 2, 4 }));
            Console.WriteLine(LinearIn(new int[] { 1, 2, 4, 6 }, new int[] { 2, 3, 4 }));
            Console.WriteLine(LinearIn(new int[] { 1, 2, 4, 4, 6 }, new int[] { 2, 4 }));
            Console.WriteLine(LinearIn(new int[] { -1, 0, 3, 3, 3, 10, 12 }, new int[] { -1, 10, 10 }));
        }

        private static bool LinearIn(int[] outer, int[] inner)
        {
            if (inner.Length == 0) return true;
            if (inner[0] < outer[0] || inner[inner.Length - 1] > outer[outer.Length - 1]) return false;

            int left = 0;
            int right = outer.Length - 1;

            while (inner[0] != outer[left])
            {
                left++;
                if (left > right) return false;
            }

            while (inner[inner.Length - 1] != outer[right])
            {
                right--;
                if (right < left) return false;
            }

            int found = 0;
            for (int i = left; i <= right; i++)
            {
                if (found < inner.Length && outer[i] == inner[found]) found++;
            }

            return found == inner.Length;
        }
    }
}

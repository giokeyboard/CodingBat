using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Start with 2 int arrays, a and b, of any length. Return how many of the arrays have 1 as their first element.
             *
             * start1([1, 2, 3], [1, 3]) → 2
             * start1([7, 2, 3], [1]) → 1
             * start1([1, 2], []) → 1
             */
            Console.WriteLine(Start1(new int[] { 1, 2, 3 }, new int[] { 1, 3 }));
            Console.WriteLine(Start1(new int[] { 7, 2, 3 }, new int[] { 1 }));
            Console.WriteLine(Start1(new int[] { 1, 2 }, new int[] { }));
        }

        private static int Start1(int[] a, int[] b)
        {
            int count = 0;
            if (a.Length > 0 && a[0] == 1) { count++; }
            if (b.Length > 0 && b[0] == 1) { count++; }
            return count;
        }
    }
}

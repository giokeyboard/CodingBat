using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Start with two arrays of strings, a and b, each in alphabetical order, possibly with duplicates.
             * Return the count of the number of strings which appear in both arrays.
             * The best "linear" solution makes a single pass over both arrays, taking advantage of the fact that
             * they are in alphabetical order.
             *
             * commonTwo(["a", "c", "x"], ["b", "c", "d", "x"]) → 2
             * commonTwo(["a", "c", "x"], ["a", "b", "c", "x", "z"]) → 3
             * commonTwo(["a", "b", "c"], ["a", "b", "c"]) → 3
             */
            Console.WriteLine(CommonTwo(new String[] { "a", "c", "x" }, new String[] { "b", "c", "d", "x" }));
            Console.WriteLine(CommonTwo(new String[] { "a", "c", "x" }, new String[] { "a", "b", "c", "x", "z" }));
            Console.WriteLine(CommonTwo(new String[] { "a", "b", "c" }, new String[] { "a", "b", "c" }));
        }

        private static int CommonTwo(string[] a, string[] b)
        {
            int count = 0;
            int i = 0;
            int j = 0;

            while (i < a.Length && j < b.Length)
            {
                if (i < a.Length - 1 && a[i] == a[i + 1])
                {
                    i++;
                    continue;
                }
                if (j < b.Length - 1 && b[j] == b[j + 1])
                {
                    j++;
                    continue;
                }

                if (a[i].Equals(b[j]))
                {
                    count++;
                    i++;
                    j++;
                }
                else if (a[i].CompareTo(b[j]) < 0)
                {
                    i++;
                }
                else if (b[j].CompareTo(a[i]) < 0)
                {
                    j++;
                }
            }

            return count;
        }
    }
}

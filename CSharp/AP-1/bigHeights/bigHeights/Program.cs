using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigHeights
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * (A variation on the sumHeights problem.) We have an array of heights, representing the altitude along a
             * walking trail. Given start/end indexes into the array, return the number of "big" steps for a walk starting
             * at the start index and ending at the end index. We'll say that step is big if it is 5 or more up or down.
             * The start end end index will both be valid indexes into the array with start <= end.
             *
             * bigHeights([5, 3, 6, 7, 2], 2, 4) → 1
             * bigHeights([5, 3, 6, 7, 2], 0, 1) → 0
             * bigHeights([5, 3, 6, 7, 2], 0, 4) → 1
             */
            Console.WriteLine(BigHeights(new int[] { 5, 3, 6, 7, 2 }, 2, 4));
            Console.WriteLine(BigHeights(new int[] { 5, 3, 6, 7, 2 }, 0, 1));
            Console.WriteLine(BigHeights(new int[] { 5, 3, 6, 7, 2 }, 0, 4));
        }

        private static int BigHeights(int[] heights, int start, int end)
        {
            int giantSteps = 0;
            for (int i = start; i < end; i++)
            {
                if (Math.Abs(heights[i] - heights[i + 1]) >= 5) giantSteps++;
            }
            return giantSteps;
        }
    }
}

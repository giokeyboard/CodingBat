using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoresClump
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of scores sorted in increasing order,
             * return true if the array contains 3 adjacent scores that differ from each other by at most 2,
             * such as with {3, 4, 5} or {3, 5, 5}.
             *
             * scoresClump([3, 4, 5]) → true
             * scoresClump([3, 4, 6]) → false
             * scoresClump([1, 3, 5, 5]) → true
             */
            Console.WriteLine(ScoresClump(new int[] { 3, 4, 5 }));
            Console.WriteLine(ScoresClump(new int[] { 3, 4, 6 }));
            Console.WriteLine(ScoresClump(new int[] { 1, 3, 5, 5 }));
        }

        private static bool ScoresClump(int[] scores)
        {
            for (int i = 0; i < scores.Length - 2; i++)
            {
                if (scores[i + 2] - scores[i] <= 2 && scores[i + 1] - scores[i] <= 2) return true;
            }
            return false;
        }
    }
}

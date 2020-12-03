using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoresIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of scores, return true if each score is equal or greater than the one before.
             * The array will be length 2 or more.
             *
             * scoresIncreasing([1, 3, 4]) → true
             * scoresIncreasing([1, 3, 2]) → false
             * scoresIncreasing([1, 1, 4]) → true
             */
            Console.WriteLine(ScoresIncreasing(new int[] { 1, 3, 4 }));
            Console.WriteLine(ScoresIncreasing(new int[] { 1, 3, 2 }));
            Console.WriteLine(ScoresIncreasing(new int[] { 1, 1, 4 }));
        }

        private static bool ScoresIncreasing(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                if (scores[i] > scores[i + 1]) return false;
            }
            return true;
        }
    }
}

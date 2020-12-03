using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scores100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of scores, return true if there are scores of 100 next to each other in the array.
             * The array length will be at least 2.
             *
             * scores100([1, 100, 100]) → true
             * scores100([1, 100, 99, 100]) → false
             * scores100([100, 1, 100, 100]) → true
             */
            Console.WriteLine(Scores100(new int[] { 1, 100, 100 }));
            Console.WriteLine(Scores100(new int[] { 1, 100, 99, 100 }));
            Console.WriteLine(Scores100(new int[] { 100, 1, 100, 100 }));
        }

        private static bool Scores100(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                if (scores[i] == scores[i + 1] && scores[i] == 100) return true;
            }
            return false;
        }
    }
}

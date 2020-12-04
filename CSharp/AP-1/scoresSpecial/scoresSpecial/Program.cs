using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoresSpecial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two arrays, A and B, of non-negative int scores. A "special" score is one which is a multiple of 10,
             * such as 40 or 90. Return the sum of largest special score in A and the largest special score in B.
             * To practice decomposition, write a separate helper method which finds the largest special score in an array.
             * Write your helper method after your scoresSpecial() method in the JavaBat text area.
             *
             * scoresSpecial([12, 10, 4], [2, 20, 30]) → 40
             * scoresSpecial([20, 10, 4], [2, 20, 10]) → 40
             * scoresSpecial([12, 11, 4], [2, 20, 31]) → 20
             */
            Console.WriteLine(ScoresSpecial(new int[] { 12, 10, 4 }, new int[] { 2, 20, 30 }));
            Console.WriteLine(ScoresSpecial(new int[] { 20, 10, 4 }, new int[] { 2, 20, 10 }));
            Console.WriteLine(ScoresSpecial(new int[] { 12, 11, 4 }, new int[] { 2, 20, 31 }));
        }

        private static int ScoresSpecial(int[] a, int[] b)
        {
            return FindMaxSpecialScore(a) + FindMaxSpecialScore(b);
        }

        private static int FindMaxSpecialScore(int[] nums)
        {
            return nums.Where(x => x % 10 == 0).DefaultIfEmpty().Max();
        }
    }
}

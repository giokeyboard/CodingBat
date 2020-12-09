using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noTeen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of integers, return a list of those numbers, omitting any that are between 13 and 19 inclusive.
             *
             * noTeen([12, 13, 19, 20]) → [12, 20]
             * noTeen([1, 14, 1]) → [1, 1]
             * noTeen([15]) → []
             */
            Console.WriteLine($"[{String.Join(",", noTeen(new List<int>(new int[] { 12, 13, 19, 20 })))}]");
            Console.WriteLine($"[{String.Join(",", noTeen(new List<int>(new int[] { 1, 14, 1 })))}]");
            Console.WriteLine($"[{String.Join(",", noTeen(new List<int>(new int[] { 15 })))}]");
        }

        private static List<int> noTeen(List<int> nums)
        {
            return nums.Where(x => x < 13 || x > 19).ToList();
        }
    }
}

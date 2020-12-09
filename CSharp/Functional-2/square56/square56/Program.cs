using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square56
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of integers, return a list of those numbers squared and the product added to 10,
             * omitting any of the resulting numbers that end in 5 or 6.
             *
             * square56([3, 1, 4]) → [19, 11]
             * square56([1]) → [11]
             * square56([2]) → [14]
             */
            Console.WriteLine($"[{String.Join(",", Square56(new List<int>(new int[] { 3, 1, 4 })))}]");
            Console.WriteLine($"[{String.Join(",", Square56(new List<int>(new int[] { 1 })))}]");
            Console.WriteLine($"[{String.Join(",", Square56(new List<int>(new int[] { 2 })))}]");
        }

        private static List<int> Square56(List<int> nums)
        {
            return nums
                .Select(x => (x * x) + 10)
                .Where(x => x % 10 != 5 && x % 10 != 6)
                .ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of integers, return a list where each integer is multiplied by 2.
             *
             * doubling([1, 2, 3]) → [2, 4, 6]
             * doubling([6, 8, 6, 8, -1]) → [12, 16, 12, 16, -2]
             * doubling([]) → []
             */
            Console.WriteLine($"[{String.Join(",", Doubling(new int[] { 1, 2, 3 }.ToList()))}]");
            Console.WriteLine($"[{String.Join(",", Doubling(new int[] { 6, 8, 6, 8, -1 }.ToList()))}]");
            Console.WriteLine($"[{String.Join(",", Doubling(new int[] { }.ToList()))}]");
        }

        private static List<int> Doubling(List<int> nums)
        {
            return nums.Select(n => n * 2).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of integers, return a list where each integer is multiplied with itself.
             *
             * square([1, 2, 3]) → [1, 4, 9]
             * square([6, 8, -6, -8, 1]) → [36, 64, 36, 64, 1]
             * square([]) → []
             */
            Console.WriteLine($"[{String.Join(",", Square(new List<int>(new int[] { 1, 2, 3 })))}]");
            Console.WriteLine($"[{String.Join(",", Square(new List<int>(new int[] { 6, 8, -6, -8, 1 })))}]");
            Console.WriteLine($"[{String.Join(",", Square(new List<int>()))}]");
        }

        private static List<int> Square(List<int> nums)
        {
            return nums.Select(n => n * n).ToList();
        }
    }
}

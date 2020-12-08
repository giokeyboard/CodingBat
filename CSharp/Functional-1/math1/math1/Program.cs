using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a list of integers, return a list where each integer is added to 1 and the result is multiplied by 10.
             *
             * math1([1, 2, 3]) → [20, 30, 40]
             * math1([6, 8, 6, 8, 1]) → [70, 90, 70, 90, 20]
             * math1([10]) → [110]
             */
            Console.WriteLine($"[{String.Join(",", Math1(new List<int>(new int[] { 1, 2, 3 })))}]");
            Console.WriteLine($"[{String.Join(",", Math1(new List<int>(new int[] { 6, 8, 6, 8, 1 })))}]");
            Console.WriteLine($"[{String.Join(",", Math1(new List<int>(new int[] { 10 })))}]");
        }

        private static List<int> Math1(List<int> nums)
        {
            return nums.Select(n => (n + 1) * 10).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a non-negative int n, return a larger string that is n copies of the original string.
             *
             * stringTimes("Hi", 2) → "HiHi"
             * stringTimes("Hi", 3) → "HiHiHi"
             * stringTimes("Hi", 1) → "Hi"
             */
            Console.WriteLine(StringTimes("Hi", 2));
            Console.WriteLine(StringTimes("Hi", 3));
            Console.WriteLine(StringTimes("Hi", 1));
        }

        private static string StringTimes(string str, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}

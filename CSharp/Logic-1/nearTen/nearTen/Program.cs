using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nearTen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a non-negative number "num", return true if num is within 2 of a multiple of 10.
             * Note: (a % b) is the remainder of dividing a by b, so (7 % 5) is 2. See also: Introduction to Mod
             *
             * nearTen(12) → true
             * nearTen(17) → false
             * nearTen(19) → true
             */
            Console.WriteLine(NearTen(12));
            Console.WriteLine(NearTen(17));
            Console.WriteLine(NearTen(19));
        }

        private static bool NearTen(int num)
        {
            return num % 10 <= 2 || Math.Abs((num % 10) - 10) <= 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icyHot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two temperatures, return true if one is less than 0 and the other is greater than 100.
             *
             * icyHot(120, -1) → true
             * icyHot(-1, 120) → true
             * icyHot(2, 120) → false
             */
            Console.WriteLine(IcyHot(120, -1));
            Console.WriteLine(IcyHot(-1, 120));
            Console.WriteLine(IcyHot(2, 120));
        }

        private static bool IcyHot(int temp1, int temp2)
        {
            return (temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0);
        }
    }
}

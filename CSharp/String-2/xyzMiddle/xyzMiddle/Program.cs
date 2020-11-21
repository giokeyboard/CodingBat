using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyzMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, does "xyz" appear in the middle of the string? To define middle,
             * we'll say that the number of chars to the left and right of the "xyz" must differ by at most one.
             * This problem is harder than it looks.
             *
             * xyzMiddle("AAxyzBB") → true
             * xyzMiddle("AxyzBB") → true
             * xyzMiddle("AxyzBBB") → false
             */
            Console.WriteLine(XyzMiddle("AAxyzBB"));
            Console.WriteLine(XyzMiddle("AxyzBB"));
            Console.WriteLine(XyzMiddle("AxyzBBB"));
        }

        private static bool XyzMiddle(string str)
        {
            while (str.Length > 4) str = str.Substring(1, str.Length - 2);
            return str.Contains("xyz");
        }
    }
}

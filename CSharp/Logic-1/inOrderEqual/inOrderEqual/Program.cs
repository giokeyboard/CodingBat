using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inOrderEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given three ints, a b c, return true if they are in strict increasing order, such as 2 5 11, or 5 6 7,
             * but not 6 5 7 or 5 5 7. However, with the exception that if "equalOk" is true, equality is allowed,
             * such as 5 5 7 or 5 5 5.
             *
             * inOrderEqual(2, 5, 11, false) → true
             * inOrderEqual(5, 7, 6, false) → false
             * inOrderEqual(5, 5, 7, true) → true
             */
            Console.WriteLine(InOrderEqual(2, 5, 11, false));
            Console.WriteLine(InOrderEqual(5, 7, 6, false));
            Console.WriteLine(InOrderEqual(5, 5, 7, true));
        }

        private static bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            return (equalOk) ? (a <= b && b <= c) : (a < b && b < c);
        }
    }
}

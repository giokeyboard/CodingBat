using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividesSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a positive int divides itself if every digit in the number divides into the number evenly.
             * So for example 128 divides itself since 1, 2, and 8 all divide into 128 evenly.
             * We'll say that 0 does not divide into anything evenly, so no number with a 0 digit divides itself.
             * Note: use % to get the rightmost digit, and / to discard the rightmost digit.
             *
             * dividesSelf(128) → true
             * dividesSelf(12) → true
             * dividesSelf(120) → false
             */
            Console.WriteLine(DividesSelf(128));
            Console.WriteLine(DividesSelf(12));
            Console.WriteLine(DividesSelf(120));
        }

        private static bool DividesSelf(int n)
        {
            int num = n;
            while (n > 0)
            {
                if (n % 10 == 0 || num % (n % 10) != 0) return false;
                n /= 10;
            }
            return true;
        }
    }
}

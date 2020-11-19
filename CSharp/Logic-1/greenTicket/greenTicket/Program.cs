using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You have a green lottery ticket, with ints a, b, and c on it.
             * If the numbers are all different from each other, the result is 0.
             * If all of the numbers are the same, the result is 20.
             * If two of the numbers are the same, the result is 10.
             *
             * greenTicket(1, 2, 3) → 0
             * greenTicket(2, 2, 2) → 20
             * greenTicket(1, 1, 2) → 10
             */
            Console.WriteLine(greenTicket(1, 2, 3));
            Console.WriteLine(greenTicket(2, 2, 2));
            Console.WriteLine(greenTicket(1, 1, 2));
        }

        private static int greenTicket(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return 20;
            }
            return (a == b || a == c || b == c) ? 10 : 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the sum of two 6-sided dice rolls, each in the range 1..6.
             * However, if noDoubles is true, if the two dice show the same value,
             * increment one die to the next value, wrapping around to 1 if its value was 6.
             *
             * withoutDoubles(2, 3, true) → 5
             * withoutDoubles(3, 3, true) → 7
             * withoutDoubles(3, 3, false) → 6
             */
            Console.WriteLine(WithoutDoubles(2, 3, true));
            Console.WriteLine(WithoutDoubles(3, 3, true));
            Console.WriteLine(WithoutDoubles(3, 3, false));
        }

        private static int WithoutDoubles(int die1, int die2, bool noDoubles)
        {
            if (noDoubles && die1 == die2)
            {
                return ((die1 == 6) ? (die1 + 1) % 6 : die1 + 1) + die2;
            }
            return die1 + die2;
        }
    }
}

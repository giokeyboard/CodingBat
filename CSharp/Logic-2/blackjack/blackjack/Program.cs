using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given 2 int values greater than 0, return whichever value is nearest to 21 without going over.
             * Return 0 if they both go over.
             *
             * blackjack(19, 21) → 21
             * blackjack(21, 19) → 21
             * blackjack(19, 22) → 19
             */
            Console.WriteLine(Blackjack(19, 21));
            Console.WriteLine(Blackjack(21, 19));
            Console.WriteLine(Blackjack(19, 22));
        }

        private static int Blackjack(int a, int b)
        {
            if (a > 21 && b > 21) return 0;
            return (a <= 21 && (b > 21 || 21 - a <= 21 - b)) ? a : b;
        }
    }
}

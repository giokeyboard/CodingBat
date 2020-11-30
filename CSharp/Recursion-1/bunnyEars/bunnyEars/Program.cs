using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunnyEars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We have a number of bunnies and each bunny has two big floppy ears.
             * We want to compute the total number of ears across all the bunnies recursively
             * (without loops or multiplication).
             *
             * bunnyEars(0) → 0
             * bunnyEars(1) → 2
             * bunnyEars(2) → 4
             */
            Console.WriteLine(BunnyEars(0));
            Console.WriteLine(BunnyEars(1));
            Console.WriteLine(BunnyEars(2));
            Console.WriteLine(BunnyEars(6));
        }

        private static int BunnyEars(int bunnies)
        {
            if (bunnies == 0) return 0;
            return 2 + BunnyEars(bunnies - 1);
        }
    }
}

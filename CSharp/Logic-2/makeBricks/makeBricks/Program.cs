using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeBricks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We want to make a row of bricks that is goal inches long.
             * We have a number of small bricks (1 inch each) and big bricks (5 inches each).
             * Return true if it is possible to make the goal by choosing from the given bricks.
             * This is a little harder than it looks and can be done without any loops. See also: Introduction to MakeBricks
             *
             * makeBricks(3, 1, 8) → true
             * makeBricks(3, 1, 9) → false
             * makeBricks(3, 2, 10) → true
             */
            Console.WriteLine(makeBricks(3, 1, 8));
            Console.WriteLine(makeBricks(3, 1, 9));
            Console.WriteLine(makeBricks(3, 2, 10));
            Console.WriteLine(makeBricks(1, 4, 11));
            Console.WriteLine(makeBricks(0, 3, 10));
            Console.WriteLine(makeBricks(20, 0, 19));
        }

        private static bool makeBricks(int small, int big, int goal)
        {
            int smallNeeded = (goal > big * 5) ? goal - big * 5 : goal % 5;
            return smallNeeded <= small;
        }
    }
}

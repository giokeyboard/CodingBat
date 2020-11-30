using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We have triangle made of blocks.
             * The topmost row has 1 block, the next row down has 2 blocks, the next row has 3 blocks, and so on.
             * Compute recursively (no loops or multiplication) the total number of blocks in such a
             * triangle with the given number of rows.
             *
             * triangle(0) → 0
             * triangle(1) → 1
             * triangle(2) → 3
             */
            Console.WriteLine(Triangle(0));
            Console.WriteLine(Triangle(1));
            Console.WriteLine(Triangle(2));
        }

        private static int Triangle(int rows)
        {
            if (rows == 0) return 0;
            return rows + Triangle(rows - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareUp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given n>=0, create an array length n*n with the following pattern, shown here for n=3 :
             * {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).
             *
             * squareUp(3) → [0, 0, 1, 0, 2, 1, 3, 2, 1]
             * squareUp(2) → [0, 1, 2, 1]
             * squareUp(4) → [0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1]
             */
            Console.WriteLine($"[{String.Join(",", SquareUp(3))}]");
            Console.WriteLine($"[{String.Join(",", SquareUp(2))}]");
            Console.WriteLine($"[{String.Join(",", SquareUp(4))}]");
        }

        private static int[] SquareUp(int n)
        {
            if (n == 0) return new int[] { };

            int[] output = new int[n * n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    output[i * n - j] = j;
                }
            }
            return output;
        }
    }
}

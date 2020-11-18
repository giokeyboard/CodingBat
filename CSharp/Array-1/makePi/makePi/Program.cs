using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makePi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return an int array length 3 containing the first 3 digits of pi, {3, 1, 4}.
             *
             * makePi() → [3, 1, 4]
             */
            Console.WriteLine("[" + String.Join(",", MakePi()) + "]");
        }

        private static int[] MakePi()
        {
            return new int[] { 3, 1, 4 };
        }
    }
}

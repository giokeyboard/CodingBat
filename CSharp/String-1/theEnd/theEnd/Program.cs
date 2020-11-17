using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a string length 1 from its front, unless front is false,
             * in which case return a string length 1 from its back. The string will be non-empty.
             *
             * theEnd("Hello", true) → "H"
             * theEnd("Hello", false) → "o"
             * theEnd("oh", true) → "o"
             */
            Console.WriteLine(TheEnd("Hello", true));
            Console.WriteLine(TheEnd("Hello", false));
            Console.WriteLine(TheEnd("oh", true));
        }

        private static string TheEnd(string str, bool front)
        {
            return (front) ? str.Substring(0, 1) : str.Substring(str.Length - 1, 1);
        }
    }
}

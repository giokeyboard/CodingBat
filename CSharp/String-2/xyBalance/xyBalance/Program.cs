using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a String is xy-balanced if for all the 'x' chars in the string,
             * there exists a 'y' char somewhere later in the string.
             * So "xxy" is balanced, but "xyx" is not. One 'y' can balance multiple 'x's.
             * Return true if the given string is xy-balanced.
             *
             * xyBalance("aaxbby") → true
             * xyBalance("aaxbb") → false
             * xyBalance("yaaxbb") → false
             */
            Console.WriteLine(XyBalance("aaxbby"));
            Console.WriteLine(XyBalance("aaxbb"));
            Console.WriteLine(XyBalance("yaaxbb"));
            Console.WriteLine(XyBalance(""));
        }

        private static bool XyBalance(string str)
        {
            return str.LastIndexOf('x') == -1 || str.LastIndexOf('y') > str.LastIndexOf('x');
        }
    }
}

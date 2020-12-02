using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parenBit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string that contains a single pair of parenthesis,
             * compute recursively a new string made of only of the parenthesis and their contents,
             * so "xyz(abc)123" yields "(abc)".
             *
             * parenBit("xyz(abc)123") → "(abc)"
             * parenBit("x(hello)") → "(hello)"
             * parenBit("(xy)1") → "(xy)"
             */
            Console.WriteLine(ParenBit("xyz(abc)123"));
            Console.WriteLine(ParenBit("x(hello)"));
            Console.WriteLine(ParenBit("(xy)1"));
        }

        private static string ParenBit(string str)
        {
            if (str[0] != '(') return ParenBit(str.Substring(1));
            if (str[str.Length - 1] != ')') return ParenBit(str.Substring(0, str.Length - 1));
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively a new string where all the 'x' chars have been removed.
             *
             * noX("xaxb") → "ab"
             * noX("abc") → "abc"
             * noX("xx") → ""
             */
            Console.WriteLine(NoX("xaxb"));
            Console.WriteLine(NoX("abc"));
            Console.WriteLine(NoX("xx"));
        }

        private static string NoX(string str)
        {
            if (str.Length == 0) return "";
            if (str[0] == 'x') return NoX(str.Substring(1));
            return str[0] + NoX(str.Substring(1));
        }
    }
}

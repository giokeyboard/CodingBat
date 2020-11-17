using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withouEnd2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given a string, return a version without both the first and last char of the string.
            * The string may be any length, including 0.
            *
            * withouEnd2("Hello") → "ell"
            * withouEnd2("abc") → "b"
            * withouEnd2("ab") → "".
            */
            Console.WriteLine(WithouEnd2("Hello"));
            Console.WriteLine(WithouEnd2("abc"));
            Console.WriteLine(WithouEnd2("ab"));
        }

        private static string WithouEnd2(string str)
        {
            return (str.Length < 3) ? "" : str.Substring(1, str.Length - 2);
        }
    }
}

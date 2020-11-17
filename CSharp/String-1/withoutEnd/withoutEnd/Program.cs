using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a version without the first and last char, so "Hello" yields "ell".
             * The string length will be at least 2.
             *
             * withoutEnd("Hello") → "ell"
             * withoutEnd("java") → "av"
             * withoutEnd("coding") → "odin"
             */
            Console.WriteLine(WithoutEnd("Hello"));
            Console.WriteLine(WithoutEnd("java"));
            Console.WriteLine(WithoutEnd("coding"));
        }

        private static string WithoutEnd(string str)
        {
            return str.Substring(1, str.Length - 2);
        }
    }
}

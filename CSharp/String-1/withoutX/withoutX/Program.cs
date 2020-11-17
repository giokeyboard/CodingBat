using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withoutX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, if the first or last chars are 'x', return the string without those 'x' chars,
             * and otherwise return the string unchanged.
             *
             * withoutX("xHix") → "Hi"
             * withoutX("xHi") → "Hi"
             * withoutX("Hxix") → "Hxi"
             */
            Console.WriteLine(WithoutX("xHix"));
            Console.WriteLine(WithoutX("xHi"));
            Console.WriteLine(WithoutX("Hxix"));
            Console.WriteLine(WithoutX("xx"));
            Console.WriteLine(WithoutX("x"));
            Console.WriteLine(WithoutX(""));
            Console.WriteLine(WithoutX("Hexllo"));
        }

        private static string WithoutX(string str)
        {
            int start = 0;
            int end = str.Length;

            if (str.Length > 0 && str[0] == 'x')
            {
                end--;
                start = 1;
            }

            if (str.Length > 1 && str[str.Length - 1] == 'x')
            {
                end--;
            }

            return str.Substring(start, end);
        }
    }
}

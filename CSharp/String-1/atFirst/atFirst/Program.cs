using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a string length 2 made of its first 2 chars.
             * If the string length is less than 2, use '@' for the missing chars.
             *
             * atFirst("hello") → "he"
             * atFirst("hi") → "hi"
             * atFirst("h") → "h@"
             */
            Console.WriteLine(atFirst("hello"));
            Console.WriteLine(atFirst("hi"));
            Console.WriteLine(atFirst("h"));
        }

        private static string atFirst(string str)
        {
            if (str.Length < 2)
            {
                return (str.Length == 1) ? str + '@' : "@@";
            }
            return str.Substring(0, 2);
        }
    }
}

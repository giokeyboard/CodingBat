using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backAround
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, take the last char and return a new string with the last char added at the front and back,
             *  so "cat" yields "tcatt". The original string will be length 1 or more.
             *
             * backAround("cat") → "tcatt"
             * backAround("Hello") → "oHelloo"
             * backAround("a") → "aaa"
             */
            Console.WriteLine(BackAround("cat"));
            Console.WriteLine(BackAround("Hello"));
            Console.WriteLine(BackAround("a"));
        }

        private static string BackAround(string str)
        {
            return str[str.Length - 1] + str + str[str.Length - 1];
        }
    }
}

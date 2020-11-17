using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraFront
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a new string made of 3 copies of the first 2 chars of the original string.
             * The string may be any length. If there are fewer than 2 chars, use whatever is there.
             *
             * extraFront("Hello") → "HeHeHe"
             * extraFront("ab") → "ababab"
             * extraFront("H") → "HHH"
             */
            Console.WriteLine(ExtraFront("Hello"));
            Console.WriteLine(ExtraFront("ab"));
            Console.WriteLine(ExtraFront("H"));
        }

        private static string ExtraFront(string str)
        {
            return (str.Length < 3) ? str + str + str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }
    }
}

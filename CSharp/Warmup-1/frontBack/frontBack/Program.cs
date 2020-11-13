using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontBack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a new string where the first and last chars have been exchanged.
             *
             * frontBack("code") → "eodc"
             * frontBack("a") → "a"
             * frontBack("ab") → "ba"
             */
            Console.WriteLine(frontBack("code"));
            Console.WriteLine(frontBack("a"));
            Console.WriteLine(frontBack("ab"));
        }

        private static string frontBack(string str)
        {
            return (str.Length < 2) ? str : str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
        }
    }
}

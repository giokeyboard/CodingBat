using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endUp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a new string where the last 3 chars are now in upper case.
             * If the string has less than 3 chars, uppercase whatever is there.
             *  Note that str.toUpperCase() returns the uppercase version of a string.
             *
             * endUp("Hello") → "HeLLO"
             * endUp("hi there") → "hi thERE"
             * endUp("hi") → "HI"
             */
            Console.WriteLine(EndUp("Hello"));
            Console.WriteLine(EndUp("hi there"));
            Console.WriteLine(EndUp("hi"));
        }

        private static string EndUp(string str)
        {
            return (str.Length < 3) ?
                str.ToUpper() :
                str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
        }
    }
}

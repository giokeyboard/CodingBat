using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a new string where "not " has been added to the front.
             * However, if the string already begins with "not", return the string unchanged.
             * Note: use .equals() to compare 2 strings.

             * notString("candy") → "not candy"
             * notString("x") → "not x"
             * notString("not bad") → "not bad"
             */
            Console.WriteLine(NotString("candy"));
            Console.WriteLine(NotString("x"));
            Console.WriteLine(NotString("not bad"));
        }

        private static string NotString(string str)
        {
            return (str.StartsWith("not")) ? str : "not " + str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changePi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively (no loops) a new string where
             * all appearances of "pi" have been replaced by "3.14".
             *
             * changePi("xpix") → "x3.14x"
             * changePi("pipi") → "3.143.14"
             * changePi("pip") → "3.14p"
             */
            Console.WriteLine(ChangePi("xpix"));
            Console.WriteLine(ChangePi("pipi"));
            Console.WriteLine(ChangePi("pip"));
        }

        private static string ChangePi(string str)
        {
            if (str.Length < 2) return str;
            if (str.StartsWith("pi")) return "3.14" + ChangePi(str.Substring(2));
            return str[0] + ChangePi(str.Substring(1));
        }
    }
}

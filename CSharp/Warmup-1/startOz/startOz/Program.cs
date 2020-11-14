using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startOz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a string made of the first 2 chars (if present),
             * however include first char only if it is 'o' and include the second only if it is 'z',
             * so "ozymandias" yields "oz".
             *
             * startOz("ozymandias") → "oz"
             * startOz("bzoo") → "z"
             * startOz("oxx") → "o"
             */
            Console.WriteLine(StartOz("ozymandias"));
            Console.WriteLine(StartOz("bzoo"));
            Console.WriteLine(StartOz("oxx"));
        }

        private static string StartOz(string str)
        {
            string result = "";

            if (str.Length > 0 && str[0] == 'o') { result += str[0]; }
            if (str.Length > 1 && str[1] == 'z') { result += str[1]; }

            return result;
        }
    }
}

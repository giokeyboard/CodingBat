using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delDel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, if the string "del" appears starting at index 1,
             * return a string where that "del" has been deleted. Otherwise, return the string unchanged.
             *
             * delDel("adelbc") → "abc"
             * delDel("adelHello") → "aHello"
             * delDel("adedbc") → "adedbc"
             */
            Console.WriteLine(DelDel("adelbc"));
            Console.WriteLine(DelDel("adelHello"));
            Console.WriteLine(DelDel("adedbc"));
        }

        private static string DelDel(string str)
        {
            if (str.Length > 3 && str.Substring(1, 3).StartsWith("del"))
            {
                return str[0] + str.Substring(4);
            }
            return str;
        }
    }
}

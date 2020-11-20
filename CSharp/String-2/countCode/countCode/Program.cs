using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the number of times that the string "code" appears anywhere in the given string,
             * except we'll accept any letter for the 'd', so "cope" and "cooe" count.
             *
             * countCode("aaacodebbb") → 1
             * countCode("codexxcode") → 2
             * countCode("cozexxcope") → 2
             */
            Console.WriteLine(CountCode("aaacodebbb"));
            Console.WriteLine(CountCode("codexxcode"));
            Console.WriteLine(CountCode("cozexxcope"));
        }

        private static int CountCode(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 3; i++)
            {
                if (str.Substring(i, 2).Equals("co") && str[i + 3] == 'e') count++;
            }
            return count;
        }
    }
}

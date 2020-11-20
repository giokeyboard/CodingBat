using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a string where for every char in the original, there are two chars.
             *
             * doubleChar("The") → "TThhee"
             * doubleChar("AAbb") → "AAAAbbbb"
             * doubleChar("Hi-There") → "HHii--TThheerree"
             */
            Console.WriteLine(DoubleChar("The"));
            Console.WriteLine(DoubleChar("AAbb"));
            Console.WriteLine(DoubleChar("Hi-There"));
        }

        private static string DoubleChar(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append($"{str[i]}{str[i]}");
            }
            return sb.ToString();
        }
    }
}

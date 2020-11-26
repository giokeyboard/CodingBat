using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return the sum of the digits 0-9 that appear in the string, ignoring all other characters.
             * Return 0 if there are no digits in the string.
             * (Note: Character.isDigit(char) tests if a char is one of the chars '0', '1', .. '9'.
             * Integer.parseInt(string) converts a string to an int.)
             *
             * sumDigits("aa1bc2d3") → 6
             * sumDigits("aa11b33") → 8
             * sumDigits("Chocolate") → 0
             */
            Console.WriteLine(SumDigits("aa1bc2d3"));
            Console.WriteLine(SumDigits("aa11b33"));
            Console.WriteLine(SumDigits("Chocolate"));
        }

        private static int SumDigits(string str)
        {
            int sumDigits = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i])) sumDigits += Convert.ToInt32(str.Substring(i, 1));
            }
            return sumDigits;
        }
    }
}

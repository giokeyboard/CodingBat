using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return the sum of the numbers appearing in the string, ignoring all other characters.
             * A number is a series of 1 or more digit chars in a row.
             * (Note: Character.isDigit(char) tests if a char is one of the chars '0', '1', .. '9'.
             * Integer.parseInt(string) converts a string to an int.)
             *
             * sumNumbers("abc123xyz") → 123
             * sumNumbers("aa11b33") → 44
             * sumNumbers("7 11") → 18
             */
            Console.WriteLine(SumNumbers("abc123xyz"));
            Console.WriteLine(SumNumbers("aa11b33"));
            Console.WriteLine(SumNumbers("7 11"));
        }

        private static int SumNumbers(string str)
        {
            int sum = 0;
            int len = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    len++;
                    if (i == str.Length - 1 || !Char.IsDigit(str[i + 1]))
                    {
                        sum += int.Parse(str.Substring(i + 1 - len, len));
                        len = 0;
                    }
                }
            }
            return sum;
        }
    }
}
